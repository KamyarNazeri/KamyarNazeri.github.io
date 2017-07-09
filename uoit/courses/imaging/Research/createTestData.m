function createTestData(img, xrange, yrange, arange)
    transforms = zeros(xrange * yrange * arange, 3);
    
    i = 1;
    for x=-xrange:xrange
        for y=-yrange:yrange
            for angle=0:arange
                transforms(i, :) = [x, y, angle];
                t = rigid(img, x, y, angle);
                imwrite(t, [num2str(i), '.jpg']);
                i = i + 1;
            end
        end
    end
    
    save transforms;
end

