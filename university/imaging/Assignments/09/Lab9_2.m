clear;
A = rgb2gray(imread('shapes.png')); 
imshow(A); 
P = ginput(1);
[m,n] = size(A);

[x,y] = meshgrid(1:n, 1:m); 
D = [(x - P(1)).^2 + (y - P(2)).^2 <= 3^2]; 
u = bwdist(1-D) - bwdist(D);
u = 0.1 * u; 
u = CVINT (A, u, 0.02); 

imshow(A);  colormap gray; 
hold on;  contour(u, [0,0], 'r');  hold off; 