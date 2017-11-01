function k = Curvature(img)
    % Computes the curvature matrix of an input grayscale image
    
    a = 0.01;               % fudge factor
    [m,n] = size(img);      % image size
    img = double(img);
    
    % u_x = (u(x+1,y) - u(x-1,y)) / 2
    u_x = (img(:,[2:n,n]) - img(:,[1,1:n-1])) / 2;
    
    % u_y = (u(x,y+1) - u(x,y+1)) / 2
    u_y = (img([2:m,m],:) - img([1,1:m-1],:)) / 2;
    
    % u_xx = u(x+1,y) - 2u(x,y) + u(x-1,y)
    u_xx = img(:,[2:n,n]) - 2 * img + img(:,[1,1:n-1]);
    
    % u_yy = u(x,y+1) - 2u(x,y) + u(x,y-1)
    u_yy = img([2:m,m],:) - 2 * img + img([1,1:m-1],:);
    
    % u_xy = (u(x+1,y+1) + u(x-1,y-1) - u(x-1,y+1) - u(x+1,y-1)) / 4
    u_xy = (img([2:m,m],[2:n,n]) + img([1,1:m-1],[1,1:n-1]) - img([2:m,m],[1,1:n-1]) - img([1,1:m-1],[2:n,n])) / 4;
    
    k_num = (u_xx .* u_y.^2) - 2 * (u_x .* u_y .* u_xy) + (u_yy .* u_x.^2);
    k_denom = (u_x.^2 + u_y.^2).^(3/2) + a;
    
    k = k_num ./ k_denom;
end

