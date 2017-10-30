function d = ludet(A)
[l, u, p] = lu(A);

sign = 1;
[row, col] = find(p);

% counting the number of permutations
for i=1:size(p)
    if(row(i) ~= i)
        j = find(row == i);         % other row index
        r = row(i);                 % current row
        q = p(i,:);                 % current permutation row
        
        row(i) = i;                 % update current row
        p(i,:) = p(r,:);            % update current permutation row
        
        row(j) = r;                 % update other row
        p(row(i),:) = q;            % update other permutation row
        
        sign = -sign;
    end
end

d = sign * prod(diag(u));