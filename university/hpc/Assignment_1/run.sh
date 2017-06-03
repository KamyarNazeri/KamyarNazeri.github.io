#!/bin/bash
#
#---------------------------------------------------------
# HPC Assignment 1.
# Different methods to run a matrix-product operation.
#---------------------------------------------------------
#

echo ""
echo "HPC Assignment 1."
echo "========================================================"
echo ""
echo ""


flag_openmp=""
flag_compiler=""
flag_fortran_link=""

for compiler in "gnu" "intel"
do
    for optimization in "-O0" "-O3"
    do
        for threads in "1" "2" "4"
        do

            # openmp flags are different for g++ and icc
            # fortran-C++ link flags are different for g++ and icc

            if [ $compiler = "gnu" ]; then
                flag_compiler="g++"
                flag_openmp="-fopenmp"
                flag_fortran_link="-lgfortran"
            else
                flag_compiler="icc"
                flag_openmp="-qopenmp"
                flag_fortran_link="-lifcore"
            fi

            if [ $threads = "1" ]; then
                flag_openmp=""
            fi


            echo ""
            echo "Compiling using $compiler compiler with $optimization optimization running on $threads thread(s)..."
            $flag_compiler mat_vec.cpp lib/cblas-$compiler.a lib/blas-$compiler.a -o result $flag_fortran_link $optimization $flag_openmp
            echo $flag_compiler mat_vec.cpp lib/cblas-$compiler.a lib/blas-$compiler.a -o result $flag_fortran_link $optimization $flag_openmp
            echo "---------------------------------------------------------------------"
            echo ""

            for product in "-D" "-L"
            do
                if [ $product = "-D" ]; then
                    echo "Running Double Loop..."
                else
                    if [ $threads != "1" ]; then
                        continue;
                    fi

                    echo "Running LAPACK..."
                fi

                ./result $product -T$threads
                echo ""
            done

            rm result
        done
    done
done