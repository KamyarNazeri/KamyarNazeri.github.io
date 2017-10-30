clear;
A = imread('pout.tif');
R = 20; 
F = fft2(A); 
[m,n] = size(A); 
[x,y] = meshgrid(1:n, 1:m); 

% A binary 0-1 mask D that describes a circle of radius R=20
D = [(x-n/2).^2 + (y-m/2).^2 < R^2]; 

% Apply the mask D to a shifted Fourier Transform
F2 = D.*fftshift(F); 

A2 = abs(ifft2(F2));

subplot(141); imagesc(A); axis image off; title('Original Image');
subplot(142); imagesc(D);  axis image off; title('Mask');
subplot(143); imagesc( log(1 + abs(fftshift(F2))) ); axis image off; title('Normalized 2D Shifted FFT');
subplot(144); imagesc(A2); axis image off; title('Low Pass');
colormap gray;