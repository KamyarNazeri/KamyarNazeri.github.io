subroutine slave
! Wait for initial data, perform Newton-Raphson when recieved
use globals
use application
implicit none
logical :: init_fail=.false.,fail,alloc_fail
integer :: received_tag,ierr,j,tag
integer, allocatable, dimension(:) :: perm
integer, dimension(MPI_STATUS_SIZE) :: status
double precision :: r
double precision, allocatable, dimension(:) :: T,res
double precision, allocatable, dimension(:,:) :: z

! Initializations for the slave processes: allocations and FFT
allocate(z(N+1,2),T(N+1),res(N+1))
! Initialize the FFT
call setup_fft(ierr)
if(ierr.ne.0) then
   print *,'MKL FFT initialization trouble, exiting.'
   init_fail=.true.
end if
! Check if all initializations were successful
call mpi_allreduce(init_fail,fail,1,MPI_LOGICAL,MPI_LOR,MPI_COMM_WORLD,ierr)

do while(.true.)   ! Only exit loop when receiving EXIT_TAG
   call MPI_RECV(z,2*(N+1),MPI_DOUBLE_PRECISION,0,MPI_ANY_TAG,MPI_COMM_WORLD, status, ierr)
   received_tag = status(MPI_TAG)
   if(received_tag.eq.EXIT_TAG) exit
   call mpi_bcast(T,N+1,MPI_DOUBLE_PRECISION,0,MPI_COMM_WORLD,ierr)

   ! Compute Newton-Raphson step, updated point returned in first argument
   call correction_step(z(:,2),z(:,1),T,alloc_fail)
   ! Compute the new residual vector
   if(.not.(alloc_fail)) then
      call residual(z(:,2),z(:,1),T,res)
      r=sqrt(sum(res**2))
      tag=DEFAULT_TAG
   else
      r=0d0
      tag=OUT_OF_MEM_TAG
   end if

   call MPI_SEND(z(:,2),N+1,MPI_DOUBLE_PRECISION,0, tag, MPI_COMM_WORLD, ierr)

   call MPI_SEND(r,1,MPI_DOUBLE_PRECISION,0, DEFAULT_TAG, MPI_COMM_WORLD, ierr)

end do

! Finalizations for slaves processes: de-allocations and FFT
call teardown_fft
deallocate(z,T,res)

return
end subroutine slave
