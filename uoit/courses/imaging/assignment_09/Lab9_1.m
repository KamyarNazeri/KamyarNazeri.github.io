clear;
A = rgb2gray(imread('shapes.png')); 
[m,n] = size(A);
[x,y] = meshgrid(1:n, 1:m); 
D = [(x - n/2).^2 + (y - m/2).^2 <= 20^2]; 
u = bwdist(1-D) - bwdist(D);
u = 0.1 * u; 
u = CVINT (A, u, 0.2); 

imshow(A);  colormap gray; 
hold on;  contour(u, [0,0], 'r');  hold off; 