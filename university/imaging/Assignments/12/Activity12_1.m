clear;
A = imread('pout.tif');
F = fft2(A); 
A2 = abs( ifft2(F) ); 

subplot(141); imagesc(A); axis image off; title('Original Image');
subplot(142); imagesc(abs(F));  axis image off; title('2D FFT');
subplot(143); imagesc( abs(fftshift(F)) ); axis image off; title('2D FFT DC Center');
subplot(144); imagesc( log(1 + abs(fftshift(F))) ); axis image off; title('Normalized 2D FFT DC Center');
colormap gray;