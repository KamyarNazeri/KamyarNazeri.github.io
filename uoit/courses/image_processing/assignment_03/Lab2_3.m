clear;
pic = imread('water.jpg');
[m, n, c] = size(pic);

%imshow(pic);
%rainbow = roipoly; 
load rainbow.mat;

map = zeros(m, n);
map(150:850, :) = repmat(1:701, [n, 1])';
masked = map .* rainbow;

filter_mean = fspecial('average', [25,25]);
pic_rainbow = imfilter(uint8(masked), filter_mean);

subplot(131); imagesc(map); title('Gradient'); colormap(jet(200)); axis image off;
subplot(132); imagesc(rainbow); title('Mask'); colormap gray; axis image off;
subplot(133); imagesc(masked); title('Rainbow'); colormap(jet(200)); axis image off;

figure();
subplot(121); imshow(pic); title('Original'); 
subplot(122); 
image(pic); 
axis image off
hold on
im = imagesc(masked);
colormap(jet(200));
im.AlphaData = max(pic_rainbow,[],3).*.2;
hold off
title('Rainbow');