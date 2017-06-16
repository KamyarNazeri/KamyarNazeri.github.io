clear;
A = imread('mm.jpg');
Y_mask = [A(:,:,1) > 120 & A(:,:,2) > 100 & A(:,:,3) < 42];
R_mask = [A(:,:,1) > 200 & A(:,:,2) < 90 & A(:,:,3) > 5];

Y_mask = imfill(Y_mask,'holes');      % fill holes
Y_mask = bwareaopen(Y_mask,200);      % remove specks

R_mask = imfill(R_mask,'holes');      % fill holes
R_mask = bwareaopen(R_mask,200);      % remove specks

Y(:,:,1) = double(A(:,:,1)).*Y_mask;
Y(:,:,2) = double(A(:,:,2)).*Y_mask;
Y(:,:,3) = double(A(:,:,3)).*Y_mask;

R(:,:,1) = double(A(:,:,1)).*R_mask;
R(:,:,2) = double(A(:,:,2)).*R_mask;
R(:,:,3) = double(A(:,:,3)).*R_mask;

subplot(231); imshow(A); title('Original');
subplot(232); imshow(Y_mask); title('Yellow Mask');
subplot(233); imshow(uint8(Y)); title('Yellow');
subplot(235); imshow(R_mask); title('Red Mask');
subplot(236); imshow(uint8(R)); title('Red');