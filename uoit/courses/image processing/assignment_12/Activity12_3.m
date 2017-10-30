clear;
A = imread('pout.tif'); 
A = double(A); 
[m,n] = size(A); 

%  vertical striped image 
[x,y] = meshgrid(1:n, 1:m); 
S = 3 + sin(x / 3);

F = fft2(S); 

f1 = figure();
subplot(131); imagesc(S); axis image off; title('striped image ');
subplot(132); imagesc(abs(fftshift(F)));  axis image off; title('Shifted FFT');
subplot(133); imagesc(log(1 + abs(fftshift(F)))); axis image off; title('Normalized 2D Shifted FFT');
colormap gray;

% corrupt the image A with stripes
B = A.*S; 
F = fft2(B); 

f2 = figure();
subplot(131); imagesc(B); axis image off; title('striped image ');
subplot(132); imagesc(abs(fftshift(F)));  axis image off; title('Shifted FFT');
subplot(133); imagesc(log(1 + abs(fftshift(F)))); axis image off; title('Normalized 2D Shifted FFT');
colormap gray;


% create a mask D that removes these 2 bright spots
D = ones(size(B)); 

%  the user to click on the bright spots in the Fourier image 
f3 = figure();
imagesc(abs(fftshift(F)));
for i = 1:2 
    P = ginput(1); 
    D( find( (x-P(1)).^2 + (y-P(2)).^2 < 5^2 ) ) = 0; 
end 

F2 = D .* fftshift(F); 
A2 = abs(ifft2(F2));

subplot(131); imagesc(B); axis image off; title('striped image ');
subplot(132); imagesc(D);  axis image off; title('Mask');
subplot(133); imagesc(A2); axis image off; title('notch filter');
colormap gray;