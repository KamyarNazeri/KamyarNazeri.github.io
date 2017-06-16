module application
use globals
use fft
! Will hold application-specific variables, initialization routine and computation of the residual and Newton-Raphson step
double precision :: A=8.09d0                        ! Parameter in the BVP we do not change
double precision,parameter :: PI=3.14159265358979d0 
complex(kind=8), parameter :: AI=(0.d0,1.d0)
contains
subroutine init_sol(z,read_fail)
! Read initial data from disk
logical :: read_fail
double precision :: z(N+1)

! Read initial data, return read_fail=TRUE if there is an error
read_fail=.false.
open(11,file='z0_12',status='old',err=2)
read(11,*,err=2) z
close(11)
return

2 print *,'Trouble reading intial data, exiting.'
read_fail=.true.
return
end subroutine init_sol

subroutine residual(z,z0,T,r)
! Compute the residual of the BVP.
! -c w' + w w' + w'' + lambda w'''' - A sin(w)=0 with periodic BC
! In: vector of unknowns z=(Re(a_0),Re(a_1),Im(a_1),...,Re(a_{m/2-1}),Im(a_{m/2-1}),Re(a_m/2),c,\lambda)
! In: current approximate solution, z, initial guess for sequence of Newton-Raphson iterations, z0; approximate tangent T to the continuation curve z(s).
! Out: residual vector r of length N+1=m+2.
integer :: fft_status,k
double precision :: z0(N+1),T(N+1),z(N+1),r(N+1),w(m),wx(m),am(m)
double precision :: lambda,c,c0

c0=z0(N)
c=z(N)
lambda=z(N+1)

! Evaluate linear part using sepctral derivatives
r(1:m)=-c*sd(z(1:m))            ! -c w'
r(1:m)=r(1:m)+sl(z(1:m),lambda) ! +w''+lambda w''''

! Evaluate advection term using pseudo-spectral approach
fft_status = DftiComputeBackward(hand, z(1:m), w)
fft_status = DftiComputeBackward(hand, sd(z(1:m)), wx)
wx=w*wx ! Point-wise product on grid
fft_status = DftiComputeForward(hand, wx, am)
r(1:m)=r(1:m)+am

! Evaluate sin(w) on grid and ack transform to Fourier space
wx=-A*sin(w)
fft_status = DftiComputeForward(hand, wx, am)
r(1:m)=r(1:m)+am

! First phase condition (no shift in x-direction)
r(N)=dot_product(z(1:m)-z0(1:m),sd(z0(1:m)))+(c-c0)

! Second phase condition (no shift along solution curve)
r(N+1)=dot_product((z-z0),T)

return
end subroutine residual

function sd(a)
! Spectral derivative. Input vector in "packed" format (see fft module)
integer :: k
double precision :: sd(m),a(m)

sd(1)=0d0
do k=1,m/2-1
   sd(2*k)=-a(2*k+1)*real(k,8)
   sd(2*k+1)=a(2*k)*real(k,8)
end do
sd(m)=0d0

return
end function sd

function sl(a,lambda)
! Symmetric linear part. Input vector in "packed" format (see fft module)
integer k
double precision :: sl(m),a(m),q,lambda

sl(1)=0d0
do k=1,m/2-1
   q=lambda*real(k,8)**4 - real(k,8)**2
   sl(2*k)=q*a(2*k)
   sl(2*k+1)=q*a(2*k+1)
end do
q=lambda*real(m/2,8)**4 - real(m/2,8)**2
sl(m)=q*a(m)

return
end function sl
subroutine correction_step(z,z0,T,alloc_failed)
! Compute the residual of the BVP, the Jacobian matrix and the Newton-Raphson update step.
! In: vector of unknowns z=(Re(a_0),Re(a_1),Im(a_1),...,Re(a_m/2-1),Im(a_m/2-1),Re(a_m/2),c,\lambda),
!     current and initial predicted point for this Nweton-Raphson sequence, z and z0, approximate tangent to the continuation curve z(s).
! Out: updated approximate solution z.
use globals
use fft
implicit none
logical :: alloc_failed
integer :: k,piv(N+1),lapack_flag,ierr
double precision :: z(N+1),z0(N+1),T(N+1),qq,lambda,c,c0,w(m),am(m),r(N+1),dum(m)
double precision, allocatable, dimension(:,:) :: J

alloc_failed=.false.
allocate(J(N+1,N+1),stat=ierr)
if(ierr.ne.0) then
   alloc_failed=.true.
   print *,'Proc ',proc_num,' could not allocate J, exiting...'
end if

if(.not.(alloc_failed)) then

J=0d0

c0=z0(N)
c=z(N)
lambda=z(N+1)

print *,'filling matrix...'

! First the advection terms
call convo(z(1:m),J)
! Left multiply by differentiation matrix and factor of 1/2
do k=1,m
   dum=sd(J(:,k))/real(m,8)
   J(:,k)=dum
end do

! derivative of -A sin(u)
fft_status = DftiComputeBackward(hand, z(1:m), w)
w=-A*cos(w)/real(m,8)
fft_status = DftiComputeForward(hand, w, am)
call convo(am,J)

! Terms originating from linear part
do k=1,m/2-1
   qq=lambda*real(k,8)**4-real(k,8)**2
   J(2*k,2*k)=J(2*k,2*k)+qq
   J(2*k,2*k+1)=J(2*k,2*k+1)+real(k,8)*c
   J(2*k+1,2*k)=J(2*k+1,2*k)-real(k,8)*c
   J(2*k+1,2*k+1)=J(2*k+1,2*k+1)+qq
end do
qq=lambda*real(m/2,8)**4-real(m/2,8)**2
J(m,m)=J(m,m)+qq

! Derivative wrt c
J(1:m,N)=-sd(z(1:m))
! Derivative wrt lambda
J(1:m,N+1)=fo(z(1:m))
! Derivative of first phase condition
J(N,1:m)=sd(z0(1:m))
J(N,N)=1d0
! Derivative of second phase condition
J(N+1,:)=T

! Solve for the Newton-Raphson update step
call residual(z,z0,T,r)

r=-r
call DGESV(N+1,1,J,N+1,piv,r,N+1,lapack_flag)
if(lapack_flag.ne.0) print *,'LAPACK warning ',lapack_flag

! Apply update step
z=z+r

else
z=0d0
end if

deallocate(J)
return
end subroutine correction_step

subroutine convo(am,J)
! Adds to J a matrix that represents the convolution with a funcion with DFT am on the finite, periodic grid.
integer :: p,q
double precision :: am(m),J(N+1,N+1),ip,rp

do p=1,m/2-1
    do q=1,m/2-1
        if(p.eq.q) then
            rp=am(1)
            ip=0d0
        else 
           if(p.gt.q) then
                rp=am(2*(p-q))
                ip=am(2*(p-q)+1)
           else
                rp=am(2*(q-p))
                ip=-am(2*(q-p)+1)
           end if
        end if
        J(2*p,2*q)=J(2*p,2*q)+rp
        J(2*p,2*q+1)=J(2*p,2*q+1)-ip
        J(2*p+1,2*q)=J(2*p+1,2*q)+ip
        J(2*p+1,2*q+1)=J(2*p+1,2*q+1)+rp
        ! contribution from omitted complex conjugate part of perturbation
        if(p+q.eq.m/2) then
            rp=am(m)
            ip=0d0
        else 
           if(p+q.gt.m/2) then
                rp=am(2*(m-p-q))
                ip=-am(2*(m-p-q)+1)
           else
                rp=am(2*(p+q))
                ip=am(2*(p+q)+1)
           end if
        end if
        J(2*p,2*q)=J(2*p,2*q)+rp
        J(2*p,2*q+1)=J(2*p,2*q+1)+ip
        J(2*p+1,2*q)=J(2*p+1,2*q)+ip
        J(2*p+1,2*q+1)=J(2*p+1,2*q+1)-rp
   end do
end do
! leftmost column
J(1:m,1)=J(1:m,1)+am
! rightmost column
J(1,m)=J(1,m)+am(m)
do p=1,m/2-1
    J(2*p,m)=J(2*p,m)+am(m-2*p)
    J(2*p+1,m)=J(2*p+1,m)-am(m-2*p+1)
end do
J(m,m)=J(m,m)+am(1)
! first row (factor of two from omitted complex conjugate part)
do q=1,m/2-1
    J(1,2*q)=J(1,2*q)+2d0*am(2*q)
    J(1,2*q+1)=J(1,2*q+1)+2d0*am(2*q+1)
end do
! last row (factor of two from omitted complex conjugate part)
do q=1,m/2-1
    J(m,2*q)=J(m,2*q)+2d0*am(m-2*q)
    J(m,2*q+1)=J(m,2*q+1)-2d0*am(m-2*q+1)
end do

return
end subroutine convo

function fo(a)
! Fourth order derivative
integer k
double precision :: fo(m),a(m),q

fo(1)=0d0
do k=1,m/2-1
   q=real(k,8)**4
   fo(2*k)=q*a(2*k)
   fo(2*k+1)=q*a(2*k+1)
end do
q=real(m/2,8)**4
fo(m)=q*a(m)

return
end function fo

end module application
