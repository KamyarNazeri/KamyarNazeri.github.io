clear;
A_ideal = imread('cameraman.tif'); 
A_large = imresize(A_ideal, [512,512]); 

A_salt = imnoise (A_ideal, 'salt & pepper', 0.1);
A_gauss = imnoise (A_large, 'gaussian', 0, 0.2); 
w = fspecial('average', [5,5]);

tic; A_mean = imfilter(A_salt, w, 'replicate'); toc
tic; A_median = medfilt2( A_salt, [5,5] ); toc

tic; A_large_mean = imfilter(A_gauss, w, 'replicate');  toc 
tic; A_large_median = medfilt2(A_gauss, [5,5] ); toc
