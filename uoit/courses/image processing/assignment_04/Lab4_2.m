clear;
A_ideal = imread('fruit.jpg'); 
[noisy_500, mean_500, mean_rmse_500, mean_snr_500, median_500, median_rmse_500, median_snr_500] = Process(A_ideal, [500,500]);
[noisy_1000, mean_1000, mean_rmse_1000, mean_snr_1000, median_1000, median_rmse_1000, median_snr_1000] = Process(A_ideal, [1000,1000]);
[noisy_2000, mean_2000, mean_rmse_2000, mean_snr_2000, median_2000, median_rmse_2000, median_snr_2000] = Process(A_ideal, [2000,2000]);
[noisy_4000, mean_4000, mean_rmse_4000, mean_snr_4000, median_4000, median_rmse_4000, median_snr_4000] = Process(A_ideal, [4000,4000]);