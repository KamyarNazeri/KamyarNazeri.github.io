clear;
A = imread('cameraman.tif');
A_noisy = imnoise(A, 'gaussian', 0, 0.01);

subplot(141); imshow(A_noisy); title('noisy');
subplot(142); imshow(tv(A_noisy, 0.01)); title('TV, lambda = 0.01');
subplot(143); imshow(tv(A_noisy, 0.1)); title('TV, lambda = 0.1');
subplot(144); imshow(tv(A_noisy, 1)); title('TV, lambda = 1');