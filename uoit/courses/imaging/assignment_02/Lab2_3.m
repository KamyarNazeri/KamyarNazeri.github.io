% RGB Thresholding with Histogram Equalization

clear;
tissue = imread('tissue.bmp');
tmask = imread('tissue_truth.bmp'); 

for i=1:3
    tissue(:,:,i) = histeq(tissue(:,:,i));
end;

dmask = [tissue(:,:,1) < 37 & tissue(:,:,2) < 29];

subplot(121); imshow(tissue); title('Histogram Equalization');
subplot(122); imshow(dmask); title('Detection Mask');

TP = sum(sum( [dmask==1 & tmask==1] ));
TN = sum(sum( [dmask==0 & tmask==0] ));
FP = sum(sum( [dmask==1 & tmask==0] ));
FN = sum(sum( [dmask==0 & tmask==1] ));

MCC = (TP * TN - FP * FN) / sqrt((TP+FP)*(TP+FN)*(TN+FP)*(TN+FN));