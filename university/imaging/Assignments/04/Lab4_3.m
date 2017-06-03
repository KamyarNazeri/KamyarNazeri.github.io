clc;
clear;
A_ideal = imread('fruit.jpg'); 
%Process(A_ideal, [50,50]);
%Process(A_ideal, [100,100]);
%Process(A_ideal, [200,200]);
%Process(A_ideal, [500,500]);
%Process(A_ideal, [1000,1000]);
%Process(A_ideal, [2000,2000]);
%Process(A_ideal, [4000,4000]);

imsize = [50, 100, 200, 500, 1000, 2000, 4000];
mean_time = [0.000412, 0.000450, 0.001119, 0.003286, 0.010378, 0.053689, 0.190688];
median_time = [0.003017, 0.003267, 0.003564, 0.005668, 0.014682, 0.059251, 0.210134];

plot(imsize, mean_time, 'DisplayName', 'Mean');
hold on;
plot(imsize, median_time, 'DisplayName', 'Median');

legend('show');
xlabel('Image Size');
ylabel('Filter Runtime');