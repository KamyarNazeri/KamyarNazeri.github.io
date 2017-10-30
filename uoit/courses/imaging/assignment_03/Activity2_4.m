A = imread('coins.png');
imshow(A);
D = roipoly; 
 
w1 = fspecial('average', [7,7]);
w2 = fspecial ('unsharp', .9);
B1 = roifilt2(w1, A, D);
B2 = roifilt2(w2, A, D);


subplot(131); imshow(A); title('Original'); 
subplot(132); imshow(B1); title('Region Mean');
subplot(133); imshow(B2); title('Region Unsharp');