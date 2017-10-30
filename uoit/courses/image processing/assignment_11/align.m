function [At, Bt] = align(A,B,T)
% Given images A and B, with transformation T that maps A to B.
% Returns images At and Bt that are the same size and aligned 
%   to a common coordinate system.

% First transform image A by T and look up the resuting bounds xA&yA.
[At,xA,yA] = imtransform(A,T);

% Set x & y bounds to enclose both image B and the transformed At.
x = [min(1, xA(1))    max(size(B,2), xA(2))];
y = [min(1, yA(1))    max(size(B,1), yA(2))];

% Transform image A by T using the new image size.
At = imtransform(A,T, 'XData', x, 'YData', y, 'FillValues', [255;255;255]);

% Map image B by an 3x3 identity matrix just so it also fits new bounds.
% Essentially this just puts black pixels around image B.
Bt = imtransform(B, maketform('affine',eye(3)), 'XData', x, 'YData', y, 'FillValues', [255;255;255]);