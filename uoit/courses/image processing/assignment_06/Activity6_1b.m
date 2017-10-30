clear; 
A = imread('peppers.png'); 
B = A;
for i=1:3; B(:,:,i) = heat(A(:,:,i)); end; 
imshow(B); 