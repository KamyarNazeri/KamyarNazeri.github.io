clear;
A = imread('pam.jpg');

% Scaling
M = [2 0 0; 
     0 2 0;
     0 0 1];
T = maketform ('affine', M); 
A_Transformed = imtransform(A, T); 
figure(); imshowpair(A, A_Transformed);


% Rotation
M = [cos(pi/4) -sin(pi/4) 0; 
     sin(pi/4) cos(pi/4) 0;
     0 0 1];
T = maketform ('affine', M);
A_Transformed = imtransform(A, T); 
figure(); imshowpair(A, A_Transformed);


% Shear
P1 = [1,3; 2,3; 1,4; 2,4];
P2 = [1, 3; 2,3; 2,4; 3,4];
T = cp2tform (P1, P2, 'affine'); 
A_Transformed = imtransform(A, T); 
figure(); imshowpair(A, A_Transformed); 