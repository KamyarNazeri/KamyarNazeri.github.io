A = imread('peppers.png');
w1 = fspecial ('gaussian', [9,9],.8);
w2 = fspecial ('gaussian', [9,9],2.5);
w3 = fspecial ('motion', 10, 120);
w4 = fspecial ('motion', 30, 120);
 
B1 = imfilter(A, w1);
B2 = imfilter(A, w2);
B3 = imfilter(A, w3);
B4 = imfilter(A, w4);
 
subplot(231); imshow(A); title('Original');
subplot(232); imshow(B1); title('Gaussian 0.8');
subplot(233); imshow(B2); title('Gaussian 2.5');
subplot(234); imshow(B3); title('Motion 10');
subplot(235); imshow(B4); title('Motion 30');