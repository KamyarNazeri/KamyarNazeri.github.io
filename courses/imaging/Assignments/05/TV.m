function [value] = TV(A)
    % Calculate TV value of an image. 
    % Input:  Grayscale image A 
    % Output: Scalar TV_value specifying the TV energy of image A 
    
    [m,n] = size(A);
    A_x = double(A(:,[2:n,n]) - A);
    A_y = double(A([2:m,m],:) - A);
    A_norm = sqrt(A_x.^2 + A_y.^2);
    value = sum(sum(A_norm));
end

