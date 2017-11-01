% HSV Thresholding

clear;
tissue = imread('tissue.bmp');
tmask = imread('tissue_truth.bmp'); 

tissue = rgb2hsv(tissue);
dmask = [tissue(:,:,1) > .7260 & tissue(:,:,1) < .8030];

subplot(121); imshow(tissue); title('HSV Image');
subplot(122); imshow(dmask); title('Detection Mask');

TP = sum(sum( [dmask==1 & tmask==1] ));
TN = sum(sum( [dmask==0 & tmask==0] ));
FP = sum(sum( [dmask==1 & tmask==0] ));
FN = sum(sum( [dmask==0 & tmask==1] ));

MCC = (TP * TN - FP * FN) / sqrt((TP+FP)*(TP+FN)*(TN+FP)*(TN+FN));