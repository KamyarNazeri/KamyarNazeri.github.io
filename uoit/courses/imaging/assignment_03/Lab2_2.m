pic = imread('water.jpg');
fast = pic;
slow = pic;

%imshow(pic);
%water1 = roipoly; 
%water2 = roipoly; 
%water3 = roipoly; 
%water4 = roipoly; 
%water5 = roipoly; 
%water6 = roipoly; 
%water7 = roipoly;
load water.mat



 
mf1 = fspecial('motion', 30, -80);
mf2 = fspecial('motion', 30, -60);
mf3 = fspecial('motion', 30, -10);
mf4 = fspecial('motion', 30, 5);
mf5 = fspecial('motion', 30, 0);
mf6 = fspecial('motion', 20, 20);
mf7 = 1/64*ones(8,8);
uf = fspecial ('unsharp', .9);

for f=1:6
    mask = eval(['water', num2str(f)]);
    ffilter = eval(['mf', num2str(f)]);
    for i=1:3;  
        fast(:,:,i) = roifilt2(ffilter, fast(:,:,i), mask);
        slow(:,:,i) = roifilt2(uf, slow(:,:,i), mask);
    end;
end; 

for i=1:3;  
    fast(:,:,i) = roifilt2(mf7, fast(:,:,i), water7);
end;


subplot(131); imshow(pic); title('Original'); 
subplot(132); imshow(fast); title('Fast');
subplot(133); imshow(slow); title('Slow');