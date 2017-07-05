A = imread('moon.tif');
A = double(A);
w1 = fspecial ('unsharp', .9);
w2 = fspecial ('laplacian', 0);
 
B1 = imfilter(A, w1);
B2 = imfilter(A, w2);
B3 = A - B2;

 
colormap gray;
subplot(141); imagesc(A); title('Original');
subplot(142); imagesc(B1); title('Unsharp a=0.9');
subplot(143); imagesc(B2); title('Laplacian');
subplot(144); imagesc(B3); title('Subtract Laplacian');