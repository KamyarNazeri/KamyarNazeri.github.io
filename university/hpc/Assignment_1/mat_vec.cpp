#include <omp.h>
#include <cmath>
#include <ctime>
#include <sys/time.h>
#include <cstdlib>
#include <iostream>
#include "cblas.h"


int SIZE = 26000;
using namespace std;


/// Type of the algorithm used for calculation
typedef enum {
    DoubleLoop = 1,
    LAPACK = 2
} CALC_METHOD;


/// Timer structure to find cpu/wall time
struct Timer {

#if defined(_OPENMP)
    double wall_time_start;
#else
    timeval wall_time_start;
#endif
    clock_t cpu_time_start;

    Timer() {
#if defined(_OPENMP)
        wall_time_start = omp_get_wtime();
#else
        gettimeofday(&wall_time_start, NULL);
#endif
        cpu_time_start = clock();
    }

    double wall_time() const {
#if defined(_OPENMP)
        return omp_get_wtime() - wall_time_start;
#else
        timeval t;
        gettimeofday(&t, NULL);
        return ((double) t.tv_sec + (double) t.tv_usec * .000001) -
               ((double) wall_time_start.tv_sec + (double) wall_time_start.tv_usec * .000001);
#endif
    }

    double cpu_time() const {
        return (clock() - cpu_time_start) / static_cast<double>(CLOCKS_PER_SEC);
    }
};


/// Uses double loop to calculate matrix-vector multiplication
void mul_DLoop(float *mat, float *vec, float *res) {
#if defined(_OPENMP)
#pragma omp parallel for
#endif
    for (int i = 0; i < SIZE; ++i) {
        res[i] = 0.0;
        for (int j = 0; j < SIZE; ++j) {
            res[i] += mat[i * SIZE + j] * vec[j];
        }
    }
}


/// Uses LAPACK to calculate matrix-vector multiplication
void mul_LAPACK(float *mat, float *vec, float *res) {
    cblas_sgemv(CblasRowMajor, CblasNoTrans, SIZE, SIZE, 1.0, mat, SIZE, vec, 1, 0, res, 1);
}


int main(int argc, char *argv[]) {

    int threads = 1;                        // number of threads (T1, T2, T4)
    CALC_METHOD type = DoubleLoop;          // type of computation (-D, -L)


    // read input arguments
    for (int i = 1; i < argc; i++) {
        string arg = string(argv[i]);

        // input argument starts with -L
        if (!arg.compare(0, 2, "-L")) {
            type = LAPACK;
        }

        // input argument starts with -T (e.g. T4)
        else if (!arg.compare(0, 2, "-T")) {
            // converts char to int. '0' = 48
            threads = argv[i][2] - '0';
        }
    }


    float *res = new float[SIZE];           // result vector
    float *vec = new float[SIZE];           // input vector
    float *mat = new float[SIZE * SIZE];    // input matrix


    srand(time(NULL));                      // initialize random number generator

    for (int i = 0; i < SIZE; ++i) {
        vec[i] = rand();                    // initialize vector
        for (int j = 0; j < SIZE; ++j) {
            mat[i * SIZE + j] = rand();     // initialize matrix
        }
    }

    Timer t;

    cout << "Size: " << SIZE << endl;
    cout << "Threads: " << (threads > 1 ? threads : 1) << endl;
    cout << "Type: " << (type == LAPACK ? "LAPACK" : "Double Loop") << endl;


#if defined(_OPENMP)
    // sets the number of threads used for parallelism
    omp_set_num_threads(threads);
#endif


    if (type == LAPACK) {
        mul_LAPACK(mat, vec, res);
    }
    else {
        mul_DLoop(mat, vec, res);
    }

    // print the actual wall-time
    cout << "Wall-Time: " << t.wall_time() << endl;
}
