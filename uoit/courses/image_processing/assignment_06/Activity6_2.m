A = imread('cameraman.tif'); 
B = anisoheat(A,20); 

subplot(121); imshow(A); title('Original');
subplot(122); imshow(B); title('Anisotropic Diffusion');