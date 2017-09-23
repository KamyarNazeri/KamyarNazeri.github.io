function trans = rigid(img, offsetX, offsetY, angle)
    imsize = size(img);
    diag = floor(sqrt(imsize(1)^2 + imsize(2)^2)) + 20;
    img = padarray(img, [(diag - imsize(1))/2, (diag - imsize(2))/2]);
    
    r = angle * pi / 180;
    t_trans = affine2d([1 0 0; 0 1 0; offsetX offsetY 1]);
    t_rotation = affine2d([cos(r) -sin(r) 0; sin(r) cos(r) 0; 0 0 1]);
    
    trans = imwarp(img,t_rotation);
    trans = imwarp(trans,t_trans,'OutputView',imref2d(size(trans)));

    imsize = size(img);
    tsize = size(trans);
    pad = floor((tsize - imsize) / 2);
    trans = trans(pad(1) + 1 : pad(1) + imsize(1), pad(2) + 1 : pad(2) + imsize(2),:);
end

