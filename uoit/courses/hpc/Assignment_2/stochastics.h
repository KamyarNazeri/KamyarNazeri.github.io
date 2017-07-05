#include <stdlib.h>
#include "mkl_vsl.h"

/// Structure for creating a pseudo-random number sequence and the stream variable.
struct Stochastics {
    VSLStreamStatePtr stream;

    Stochastics() {
        srand(time(NULL));             // initializes random seed
        int seed = rand() % 100 + 1;    // generates seed between 1 and 10

        // Uncomment this line if you want to fix the seed to generate the same sequence repeatedly (for debugging)
        // seed = 666;

        // initialize random number stream
        vslNewStream(&stream, VSL_BRNG_MT19937, seed);
    }

    ~Stochastics() {
        // Delete random number stream
        vslDeleteStream(&stream);
    }

    /// Creates n pseudo-random numbers drawn from a normal distribution
    /// with standard deviation sig in array arr
    void create(double *arr, int n, double sig) {
        // VSL_RNG_METHOD_GAUSSIAN_ICDF:
        // specifies the method by which the homogeneously distributed number
        // in the stream are converted to (0,sig) normally distributed numbers.
        vdRngGaussian(VSL_RNG_METHOD_GAUSSIAN_ICDF, stream, n, arr, 0, sig);
    }
};