function snr = SNR(denoised, ideal)
    % Calculates Signal-to-Noise ratio. 
    % Input: Filtered image (denoised). Ideal image (ideal)
    % Output: Scalar snr specifying the SNR of a filter 
    snr = 20*log(norm(double(ideal), 'fro')/(norm(double(ideal) - double(denoised), 'fro')));
end