clear;
A = imread('coins.png'); 
[m,n] = size(A); 
[x,y] = meshgrid(1:n, 1:m); 
D = [(x - n/2).^2 + (y - m/2).^2 <= 100^2]; 
u = bwdist(1-D)- bwdist(D); 
u = 0.1*u;

figure();
surf(u);

figure();
imagesc(u);  colorbar; 

figure();
imshow(A);   hold on; 
contour(u, [0,0], 'r');   hold off; 