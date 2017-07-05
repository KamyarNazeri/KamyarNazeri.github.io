clear;
A_ideal = imread('cameraman.tif'); 
A_salt = imnoise (A_ideal, 'salt & pepper', 0.1);
w = fspecial('average', [5,5]);
A_mean = imfilter(A_salt, w, 'replicate');
A_median = medfilt2( A_salt, [5,5] ); 


RMSE_mean = RMSE(A_mean, A_ideal); 
RMSE_median = RMSE(A_median, A_ideal); 

SNR_mean = SNR(A_mean, A_ideal);
SNR_median = SNR(A_median, A_ideal);