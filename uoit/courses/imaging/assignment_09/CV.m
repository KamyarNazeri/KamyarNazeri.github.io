function [u] = CV(f, lambda)
    % Chan-Vese segmentation algorithm using level sets
    
    %Parameters
    dt = 0.2;               % time step
    T = 100;                % stopping time
    a = 0.1;                % fudge factor
    e = 0.1;                % epsilon (Dirac function)
    [m,n] = size(f);        % image size
    f = double(f);          % convert to double
    
    [x,y] = meshgrid(1:n, 1:m); 
    D = [(x - n/2).^2 + (y - m/2).^2 <= 100^2]; 
    u = bwdist(1-D) - bwdist(D);
    u = 0.1 * u; 
    
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
        
        dirac = e ./(pi * (e^2 + u.^2));
        cin =  sum(sum(f .* [ u>0 ])) / sum(sum([u > 0]));
        cout =  sum(sum(f .* [ u<0 ])) / sum(sum([u <0 ]));
        
        pde = dirac .* (k_num./k_denom - lambda*(f - cin).^2 + lambda*(f - cout).^2);
        
        u = u + dt * pde;
        
        %imshow(uint8(f));  colormap gray; title(['iteration: ',num2str(t)]);
        %hold on;  contour(u, [0,0], 'r');  hold off;  drawnow; 
    end
end

