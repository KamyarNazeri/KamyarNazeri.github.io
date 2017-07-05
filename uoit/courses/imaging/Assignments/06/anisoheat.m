function [u] = anisoheat (f, a)
    %Anisotropic heat equation
    %Input: Initial temperature distribution f
    %Output: Solution of the heat equation u

    %Parameters
    dt = 0.1;   %Time step
    T = 20;     %Stopping time
    K = 0;      %Conductivity

    %Initialize u=f.  Convert to double so we can do arithmetic.
    u = double(f);
    [m,n] = size(u);

    for t = 0:dt:T
        u_x = u(:,[2:n,n]) - u;             % u_x forward difference
        u_y = u([2:m,m],:) - u;             % u_y forward difference
        norm = sqrt(u_x.^2 + u_y.^2);       % norm of the gradient
        K = exp(-(norm./a).^2);             % Perona-Malik exp edge-stopping 

        p_x = K .* u_x;                     % pointwise K.u_x
        p_x = p_x - p_x(:,[1,1:n-1]);       % backward difference u_x(p_x)

        p_y = K .* u_y;                     % pointwise K.u_y
        p_y = p_y - p_y([1,1:m-1],:);       % backward difference u_y(p_y)

        u = u + dt * (p_x + p_y);       % anisotropic forward euler

        imshow(uint8(u)); 
        title(['t=',num2str(t)]);
        drawnow;
    end

    u = uint8(u);

end

