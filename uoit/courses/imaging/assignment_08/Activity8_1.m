clear;
A = imread('cameraman.tif'); 
A = double(A);

D1 = ones(size(A)); 
D1(20:220,150:160)=0;
A1 = D1.*A; 

D2 = ones(size(A)); 
D2(3:3:256,:) = 0; 
A2 = D2.*A; 

D3 = 1 - imread('text.png'); 
A3 = D3.*A; 

subplot(141); imshow(uint8(A)); title('Original');
subplot(142); imshow(uint8(A1)); title('Vertical Bar');
subplot(143); imshow(uint8(A2)); title('Skip Lines');
subplot(144); imshow(uint8(A3)); title('Overlapping Text');