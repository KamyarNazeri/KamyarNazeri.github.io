function [u] = tv(f, lambda)
    % Computes the total variation of an input grayscale image
    
    %Parameters
    dt = 0.1;               % time step
    T = 20;                 % stopping time
    a = 0.1;                % fudge factor
    [m,n] = size(f);        % image size
    f = double(f);          % convert to double
    u = f;                  % initialization
    
    for t = 0:dt:T
        % u_x = (u(x+1,y) - u(x-1,y)) / 2
        u_x = (u(:,[2:n,n]) - u(:,[1,1:n-1])) / 2;

        % u_y = (u(x,y+1) - u(x,y+1)) / 2
        u_y = (u([2:m,m],:) - u([1,1:m-1],:)) / 2;

        % u_xx = u(x+1,y) - 2u(x,y) + u(x-1,y)
        u_xx = u(:,[2:n,n]) - 2 * u + u(:,[1,1:n-1]);

        % u_yy = u(x,y+1) - 2u(x,y) + u(x,y-1)
        u_yy = u([2:m,m],:) - 2 * u + u([1,1:m-1],:);

        % u_xy = (u(x+1,y+1) + u(x-1,y-1) - u(x-1,y+1) - u(x+1,y-1)) / 4
        u_xy = (u([2:m,m],[2:n,n]) + u([1,1:m-1],[1,1:n-1]) - u([2:m,m],[1,1:n-1]) - u([1,1:m-1],[2:n,n])) / 4;

        k_num = (u_xx .* u_y.^2) - 2 * (u_x .* u_y .* u_xy) + (u_yy .* u_x.^2);
        k_denom = (u_x.^2 + u_y.^2).^(3/2) + a;
        pde = k_num ./ k_denom - 2 * lambda * (u - f);
        
        u = u + dt * pde;
    end
    
    u = uint8(u);
end