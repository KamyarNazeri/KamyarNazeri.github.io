clear;
Left = imread('left.jpg'); 
Right = imread('right.jpg'); 

% Control Point Selection Tool 
% cpselect (Left, Right);
load points

subplot(121); imagesc(Left); hold on;  
plot(P_Left(:,1), P_Left(:,2), 'ro'); hold off; 
subplot(122); imagesc(Right); hold on;  
plot(P_Right(:,1), P_Right(:,2), 'ro'); hold off;


% The affine transformation that maps P_Left to P_Right
T = cp2tform (P_Left, P_Right, 'affine'); 
Left_Transformed = imtransform (Left, T); 

%figure(); imshow(Left_Transformed); 
%figure(); imshowpair (Left_Transformed, Right); 


%  place the transformed image and the original Right image on the same coordinate axes
[Left_Transformed, Right_Transformed] = align (Left, Right, T); 
%figure(); imshowpair (Left_Transformed, Right); 

% Average the images, to make one image
I1 = (Left_Transformed + Right_Transformed) / 2; 

% Taking the minimum value, to make one image
I2 = min (Left_Transformed, Right_Transformed); 
figure(); imshow(I2); 

