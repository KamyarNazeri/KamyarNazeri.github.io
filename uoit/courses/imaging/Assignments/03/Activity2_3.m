load woman;
A = double(X);
w1 = fspecial ('prewitt');
w2 = fspecial ('log', [9,9], 0.8);
H = imfilter (A, w1);
V = imfilter (A, w1');
Z = imfilter (A, w2');
 
colormap gray;
subplot(141); imagesc(A); title('Original');
subplot(142); imagesc(H); title('Prewitt');
subplot(143); imagesc(V); title('Prewitt Transpose');
subplot(144); imagesc(Z); title('LoG');