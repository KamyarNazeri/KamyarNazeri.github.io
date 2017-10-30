clear;
A = imread('coins.png'); 
u = CV (A, 0.01); 

imshow(A);  colormap gray; 
hold on;  contour(u, [0,0], 'r');  hold off; 