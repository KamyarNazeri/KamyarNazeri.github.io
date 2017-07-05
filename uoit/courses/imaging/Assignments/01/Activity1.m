a = imread('a.jpg');
a_A = a(400:550, 550:850,:);
a_B = a(300:400, 500:600,:);
a_C = a(100:300, 600:850,:);

%imagesc(a);
%figure()

subplot(1, 4, 1);
imshow(a);
title('original');

subplot(1, 4, 2);
imagesc(a_A);
title([a_A(80, 200, 1), a_A(80, 200, 2), a_A(80, 200, 3)]);

subplot(1, 4, 3);
imagesc(a_B);
title([a_B(50, 60, 1), a_B(50, 60, 2), a_B(50, 60, 3)]);

subplot(1, 4, 4);
imagesc(a_C);
title([a_C(100, 100, 1), a_C(100, 100, 2), a_C(100, 100, 3)]);

