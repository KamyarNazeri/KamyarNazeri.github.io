function res = Pi2(n)
    res = 0;
    c = 1;
    for i=1:n
        p = (2*i - 1);
        res = res + (6 * c * 0.5^p / p);
        c = c * (p / (2*i));
    end
end

