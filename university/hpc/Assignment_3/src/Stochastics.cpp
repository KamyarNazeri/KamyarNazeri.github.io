#include <stdlib.h>
#include <assert.h>
#include <time.h>
#include "mkl.h"


VSLStreamStatePtr stream;               // stream of pseudo-random numbers


/// Initialize a random numbers generator
void initialize_RNG(){
    srand(time(NULL));                  // initializes random seed
    int seed = rand() % 100 + 1;        // generates seed between 1 and 10

    // Uncomment this line if you want to fix the seed to generate the same sequence repeatedly (for debugging)
    // seed = 666;

    // initialize random number stream
    int status = vslNewStream(&stream, VSL_BRNG_MT19937, seed);
    assert(status == VSL_STATUS_OK);
}


/// Finalize random numbers generator
void finalize_RNG(){
    // Delete random number stream
    int status = vslDeleteStream(&stream);
    assert(status == VSL_STATUS_OK);
}


/// Creates 'n' random numbers with normal distribution and standard deviation 'sig' in the array 'arr'
void RNG_Gaussian(double *arr, int n, double sig){
    // VSL_RNG_METHOD_GAUSSIAN_ICDF:
    // specifies the method by which the homogeneously distributed number
    // in the stream are converted to (0,sig) normally distributed numbers.
    int status = vdRngGaussian(VSL_RNG_METHOD_GAUSSIAN_ICDF, stream, n, arr, 0, sig);
    assert(status == VSL_STATUS_OK);
}


/// Creates 'n' random numbers with uniform distribution ranging from 'a' to 'b' in the array 'arr'
void RNG_Uniform(double *arr, int n, double a, double b) {
	int status = vdRngUniform(VSL_RNG_METHOD_UNIFORM_STD, stream, n, arr, a, b);
	assert(status == VSL_STATUS_OK);
}