clear;
load lab8;

DA = double([A ~= 255 & A ~= 0]); 
DB = double([B ~= 255 & B ~= 0]); 

figure();
subplot(121); imshow(A); title('Noisy Image A');
subplot(122); imshow(TV_inpaint(A,0.5,DA)); title('Restored Image A');

figure();
subplot(121); imshow(B); title('Noisy Image B');
subplot(122); imshow(TV_inpaint(B,0.5,DB)); title('Restored Image B');