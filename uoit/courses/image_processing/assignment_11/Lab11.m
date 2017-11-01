clear;
A = imread('1.png');
B = imread('2.png');

[m,n,k] = size(B); 
A = imresize(A,[m,n]);

load Lab11_points.mat

%select corresponding control points in both images
%cpselect (A, B);

for t=0:0.01:1 
    % gradually warp the image A to B by
    % performing weighted average of the control points
    P_mid = (1-t)*PA + t*PB;
    
    % affine transformation that maps the points PA to P_mid  
    T_mid = cp2tform(PA, P_mid, 'affine'); 
    
    % put both images on the same coordinate system
    [A_T, B_T] = align (A, B, T_mid); 
    
    % cross-fade between two aligned images
    I = (1-t)*A_T + t*B_T; 
    
    if mod(t,0.2) == 0 
        subplot(2,3,1+5*t); 
        imagesc(I); axis image off; drawnow; 
    end; 
end;

