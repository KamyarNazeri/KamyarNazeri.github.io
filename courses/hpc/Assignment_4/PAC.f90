module PAC
! Will hold PAC-specific variables and routines
implicit none
integer :: nsteps
double precision :: ds0,h
contains
subroutine set_PAC_parameters
nsteps=10
ds0=1d-3
h=0.05d0
end subroutine set_PAC_parameters
end module PAC
