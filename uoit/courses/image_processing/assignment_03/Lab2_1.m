pic = imread('run.jpg');
masked = pic;
%imshow(pic);
%cadet = roipoly; 
load cadet.mat
 
filter1 = fspecial('motion', 12, 10);
filter2 = fspecial ('motion', 2, 40);
filter3 = fspecial ('unsharp', .5);

for i=1:3;  
    fast1(:,:,i) = roifilt2(filter1, pic(:,:,i), cadet);
    slow1(:,:,i) = roifilt2(filter3, pic(:,:,i), cadet);
    masked(:,:,i) = double(pic(:,:,i)).*cadet;
end; 

fast2 = imfilter(uint8(masked), filter1);
slow2 = deconvwnr(masked, filter2);


%-------------- Fast
subplot(231); imshow(pic); title('Original'); 
subplot(232); imshow(fast1); title('Fast using roifilt2');
subplot(233); 
image(pic); 
axis image off
hold on
im = image(fast2);
im.AlphaData = max(fast2,[],3);
im2 = image(fast2);
im2.AlphaData = max(fast2,[],3);
hold off
title('Fast using imfilter');


%-------------- Slow
subplot(235); imshow(slow1); title('Slow using unsharp');
subplot(236); 
image(pic); 
axis image off
hold on
im = image(slow2);
im.AlphaData = max(slow2,[],3);
hold off
title('Slow using deconv');