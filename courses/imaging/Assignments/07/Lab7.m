clear;
A_ideal = imread('peppers.png'); 
A_noisy = imnoise(A_ideal, 'gaussian', 0, 0.01); 
[A_tv1, A_snr1, A_rmse1] = colortv(A_noisy, 0.01);
[A_tv2, A_snr2, A_rmse2] = colortv(A_noisy, 0.1);
[A_tv3, A_snr3, A_rmse3] = colortv(A_noisy, 1);

subplot(141); imshow(A_noisy); title('noisy');
subplot(142); imshow(A_tv1); title('TV, lambda = 0.01');
subplot(143); imshow(A_tv2); title('TV, lambda = 0.1');
subplot(144); imshow(A_tv3); title('TV, lambda = 1');