clear;
u = imread('test.bmp');
c = Curvature(u);

colormap gray;
subplot(121); imagesc(u); title('Original'); axis image off;
subplot(122); imagesc((c)); title('Curvature'); axis image off;