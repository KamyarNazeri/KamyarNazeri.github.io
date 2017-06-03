clear;
A_ideal = imread('cameraman.tif'); 
A_gauss = imnoise(A_ideal, 'gaussian', 0, 0.02); 
w = fspecial('average', [5,5]);
A_mean = imfilter(A_gauss, w, 'replicate');
A_median = medfilt2( A_gauss, [5,5] ); 

subplot(141); imshow(A_ideal); title('ideal');
subplot(142); imshow(A_gauss); title('noisy');
subplot(143); imshow(A_mean); title('mean filter');
subplot(144); imshow(A_median); title('median filter');