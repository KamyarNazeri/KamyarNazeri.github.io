clear;
u = imread('cameraman.tif'); 
u = double(u);

[m,n] = size(u);
u_x = (u(:,[2:n,n]) - u(:,[1,1:n-1])) / 2;
u_y = (u([2:m,m],:) - u([1,1:m-1],:)) / 2;
u_norm = sqrt(u_x.^2 + u_y.^2);

subplot(241); imshow(uint8(u)); title('Original');
subplot(242); imshow(uint8(u_x)); title('X Derivative');
subplot(243); imshow(uint8(u_y)); title('Y Derivative');
subplot(244); imshow(uint8(u_norm)); title('Norm');

subplot(245); imagesc(uint8([u_norm > 25])); title('t > 25'); axis off;
subplot(246); imagesc(uint8([u_norm > 50])); title('t > 50'); axis off;
subplot(247); imagesc(uint8([u_norm > 75])); title('t > 75'); axis off;
subplot(248); imagesc(uint8([u_norm > 100])); title('t > 100'); axis off;