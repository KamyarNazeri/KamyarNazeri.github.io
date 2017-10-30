clear;
A_ideal = imread('fruit.jpg'); 
[noisy, mean, mean_rmse, mean_snr, median, median_rmse, median_snr] = Process(A_ideal, [500,500]);

subplot(131); imshow(noisy); title('noisy');
subplot(132); imshow(mean); title('mean filter');
subplot(133); imshow(median); title('median filter');