n = 100;
x = 1:n;
p1 = 1:n;
p2 = 1:n;

for i=1:n
    p1(i) = Pi1(i);
    p2(i) = Pi2(i);
end

figure;
subplot(121);
plot(x, p1, '.', x, p2, '.');
ylabel('Approximate Value of \pi')
xlabel('Number of Terms');
title('Different methods for approximation of \pi');
legend('1st series', '2nd series');

subplot(122);
plot(x, abs(pi-p1), x, abs(pi-p2));
ylabel('Approximate Error')
xlabel('Number of Terms');
title('Errors with different methods for approximation of \pi');
legend('1st series', '2nd series');