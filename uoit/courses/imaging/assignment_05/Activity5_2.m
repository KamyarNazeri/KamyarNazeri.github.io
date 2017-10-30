clear;
P = imread('pout.tif'); 
P_noisy = imnoise(P, 'salt & pepper', 0.05); 

x = TV(P);
x_noisy = TV(P_noisy);

P = imread('pout.tif'); 
for i = 1:10 
    P = imnoise(P, 'salt & pepper', 0.02); 
    imshow(P); 
    x = TV(P); 
    xlabel( [ 'TV = ', num2str(x) ] ); 
    title( [ 'Iteration #', num2str(i) ] ); 
    pause(0.5); 
end;