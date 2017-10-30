clear;
A = imread('mm.jpg');
D = [A(:,:,1) > 120 & A(:,:,2) > 100 & A(:,:,3) < 42];
D = imfill(D,'holes');      % fill holes
D = bwareaopen(D,200);      % remove specks
D = imdilate(D, strel('disk',1));

G = imread('mm_truth.bmp'); 
M(:,:,1)=D;  
M(:,:,2)=G;  
M(:,:,3)=0;

colormap gray;
subplot(131); imagesc(D); title('Detection Mask');
subplot(132); imagesc(G); title('True Mask');
subplot(133); imagesc(M); title('Difference');


TP = sum(sum( [D==1 & G==1] ));
TN = sum(sum( [D==0 & G==0] ));
FP = sum(sum( [D==1 & G==0] ));
FN = sum(sum( [D==0 & G==1] ));

MCC = (TP * TN - FP * FN) / sqrt((TP+FP)*(TP+FN)*(TN+FP)*(TN+FN));