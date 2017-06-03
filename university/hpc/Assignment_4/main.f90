module globals
implicit none
include 'mpif.h'
integer, parameter :: m=2**12,N=m+1    ! Number of grid points, number of unknowns (excluding continuation parameter)
integer :: num_procs,proc_num          ! Num of procs, num of this proc
integer :: EXIT_TAG=42,DEFAULT_TAG=43  ! Master sends EXIT_TAG to make slaves exit and DEFAULT_TAG otherwise
integer :: OUT_OF_MEM_TAG=40           
double precision :: void=0d0           ! "empty" message to send along with EXIT_TAG
end module globals
include 'NR.f90'
include 'PAC.f90'
include 'fft.f90'
include 'application.f90'
include 'master.f90'
include 'slave.f90'

program main
! Main program - only does MPI initialization/finalization and divides master and slaves
use globals
implicit none
logical :: ok
integer :: ierr

call start_MPI(ok)                 ! Initialize MPI
if(ok) then                        ! If initialization was successful
   select case(num_procs)
      case(1)                      ! Only one process is not enough for master-slave model
         print *,'We need at least two processes, exiting...'
      case default                 ! All good, start the work
         if(proc_num.eq.0) then
            call master            ! Master goes through PAC iterations
         else
            call slave             ! Slaves wait for initial data for single Newton iteration
         end if
   end select
end if

call stop_MPI                      ! Done, finalize and exit

end program main

subroutine start_MPI(ok)
use globals
implicit none
! MPI initialization
logical :: my_ok=.true.,ok
integer :: ierr
call mpi_init(ierr)
if(ierr.ne.0) then
   print *,'MPI_init failed!'
   my_ok=.false.
end if
if(my_ok) then
   call mpi_comm_size(MPI_COMM_WORLD,num_procs,ierr)
   if(ierr.ne.0) then
      print *,'MPI_comm_size failed!'
      my_ok=.false.
   end if
   if(my_ok) then
      call mpi_comm_rank(MPI_COMM_WORLD,proc_num,ierr)
      if(ierr.ne.0) then
         print *,'MPI_comm_rank failed!'
         my_ok=.false.
      end if
   end if
end if
! Check if everyone is ok.
call mpi_allreduce(my_ok,ok,1,MPI_LOGICAL,MPI_LAND,MPI_COMM_WORLD,ierr)

end subroutine start_MPI

subroutine stop_MPI
use globals
implicit none
logical :: init
integer :: ierr

! Wait until everybody is done. One process "finalize"ing while others are still working can cause ugly crashes.
call mpi_barrier(MPI_COMM_WORLD,ierr)
! Check if MPI has been initialized.
call mpi_initialized(init,ierr)
! If it is, call finalize.
if(init) call mpi_finalize(ierr)

end subroutine stop_MPI

