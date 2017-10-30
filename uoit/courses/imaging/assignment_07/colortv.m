function [u, snr, rmse] = colortv(f, lambda)
    u = f;
    for i=1:3; 
        u(:,:,i) = tv(f(:,:,i), lambda); 
    end;
    
    snr = SNR(rgb2gray(f), rgb2gray(u));
    rmse = RMSE(rgb2gray(f), rgb2gray(u));
end