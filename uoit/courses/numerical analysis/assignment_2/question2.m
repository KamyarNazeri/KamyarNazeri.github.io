%% =========== Part a: compute the coef?cient matrix A  ==================

n = 12;                     % polynomial degree: (n-1)
m = 50;                  	% number of samples

x = linspace(0, 1, m);      % sample m points on the interval [0,1]
f = cos(4 * x)';            % evaluate function on sample points 
A = fliplr(vander(x));      % create the Vandermonde Matrix
A = A(:,1:n);               % get polynomials up to (n-1)


%% =========== Part b: Cholesky decomposition  ===========================
% to solve the overdetermined system of equations Ac = f
% we calculate Cholesty decomposition of A'A and get A'A = LL'
% multiply both sides of the equation by A' => A'Ac=A'f => LL'c=A'f
% to solve for c: c_chol = inv(LL')A'f

[L] = chol(A'*A,'lower');   % produces a lower triangular matrix L 
c_chol = L' \ (L \ (A'*f));


%% =========== Part c: QR decomposition ==================================
% to solve the overdetermined system of equations Ac = f
% we calculate QR decomposition of A and get A = QR
% to solve for c: c_qr = inv(R)*Q'*f

[Q,R] = qr(A,0);            % reduced QR factors
c_qr = R\(Q'*f);            % inv(Q)=Q'


%% =========== Part d: SVD decomposition =================================
% to solve the overdetermined system of equations Ac = f
% we calculate SVD decomposition of A and get A = USV
% to solve for c: c_svd = inv(USV)f

[U,S,V] = svd(A,0);         % performs a svd of matrix A
c_svd = V / S * U' * f;     % inv(U)=U' and inv(V')=V

%% =========== Part e: plot the absolute residuals =======================

r_chol = abs(f - A * c_chol); 
r_qr = abs(f - A * c_qr);
r_svd = abs(f - A * c_svd);

plot(x, r_chol, x, r_qr, x, r_svd);
legend('Cholesky decomposition', 'QR decomposition', 'SVD decomposition');
set(gca,'yscale','log');

format long
T = table(c_chol, c_qr, c_svd);
T.Properties.VariableNames = {'Cholesky' 'QR' 'SVD'};
disp(T)