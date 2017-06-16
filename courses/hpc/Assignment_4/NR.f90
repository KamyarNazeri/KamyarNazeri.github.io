module NR
use globals
implicit none
integer :: nnwt
double precision :: tol
contains
subroutine set_NR_parameters
nnwt=5
tol=1d-8
return
end subroutine set_NR_parameters
end module NR
