clear;
tissue = imread('tissue.bmp');
tmask = imread('tissue_truth.bmp'); 

cmask = [tissue(:,:,1) < 129 & tissue(:,:,2) < 79 & tissue(:,:,3) > 116];
dmask = imdilate(cmask, strel('disk',2));   % dilate cells
dmask = bwareaopen(dmask,50);               % remove specks
dmask = imfill(dmask,'holes');              % fill holes

cancer(:,:,1) = double(tissue(:,:,1)).*tmask;
cancer(:,:,2) = double(tissue(:,:,2)).*tmask;
cancer(:,:,3) = double(tissue(:,:,3)).*tmask;
cancer = uint8(cancer);

subplot(131); imshow(tissue); title('Tissue');
subplot(132); imshow(cancer); title('Cancer Cells');
subplot(133); imshow(tissue - cancer); title('Normal Cells');
figure();

diff(:,:,1)=dmask;  
diff(:,:,2)=tmask;  
diff(:,:,3)=0;

colormap gray;
subplot(221); imagesc(cmask); title('Detection Mask');
subplot(222); imagesc(dmask); title('Binary Image Operations');
subplot(223); imagesc(tmask); title('True Mask');
subplot(224); imagesc(diff); title('Difference');


TP = sum(sum( [dmask==1 & tmask==1] ));
TN = sum(sum( [dmask==0 & tmask==0] ));
FP = sum(sum( [dmask==1 & tmask==0] ));
FN = sum(sum( [dmask==0 & tmask==1] ));

MCC = (TP * TN - FP * FN) / sqrt((TP+FP)*(TP+FN)*(TN+FP)*(TN+FN));