function res = Pi1(n)
    res = 0;
    for i=1:n
        res = res + (-1)^(i+1) * 4 / (2*i-1);
    end
end

