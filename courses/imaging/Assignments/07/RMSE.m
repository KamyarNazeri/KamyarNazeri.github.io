function rmse = RMSE(denoised, ideal)
    % Calculates RMS error. 
    % Input: Filtered image (denoised). Ideal image (ideal)
    % Output: Scalar rmse specifying the RMSE of a filter 
    [m,n] = size(ideal);
    rmse = 1/(m*n)*norm( double(denoised)-double(ideal),'fro'); 
end