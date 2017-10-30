function [noisy, mean, mean_rmse, mean_snr, median, median_rmse, median_snr] = Process(img, size)
    % Calculates Lab4 statistics. 
    % Input: Image (img). Size of the image (size)
    
    resized = imresize(img, size);
    median = resized;
    noisy = imnoise (resized, 'salt & pepper', 0.05);
    w = fspecial('average', [5,5]);

    display(['Calculating mean filter ', num2str(size(1))]);
    tic; mean = imfilter(noisy, w, 'replicate'); toc

    display(['Calculating median filter ', num2str(size(1))]);
    tic;
    for i=1:3
        median(:,:,i) = medfilt2(noisy(:,:,i), [5,5]);
    end;
    toc
    
    resized_gs = rgb2gray(resized);
    mean_gs = rgb2gray(mean);
    median_gs = rgb2gray(median);
    
    mean_rmse = RMSE(mean_gs, resized_gs);
    mean_snr = SNR(mean_gs, resized_gs);
    
    median_rmse = RMSE(median_gs, resized_gs);
    median_snr = SNR(median_gs, resized_gs);
end