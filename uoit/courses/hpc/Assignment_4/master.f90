subroutine master
use globals
use PAC
use NR
use application
implicit none
! Execute PAC algorithm but distribute Newton-Raphson steps for different approximate solutions over slaves
logical :: init_fail,fail,slave_trouble, promising
integer :: step,j,k,ierr,received_tag,max_converged, extra_iteration, max_iteration
integer, dimension(MPI_STATUS_SIZE) :: status
double precision, allocatable, dimension(:) :: T,r,z,ds  ! Tangent to solution curve, array of residuals, current solution, step sizes
double precision, allocatable, dimension(:,:,:) :: pred  ! Predictions for new solution and intermediate approximate solutions

allocate(T(N+1),pred(N+1,1:num_procs-1,2),r(num_procs-1),z(N+1),ds(num_procs-1))

! Initializations for master process
! Read Newton-Raphson parameters
call set_NR_parameters
! Read PAC parameters
call set_PAC_parameters
! Open file for writing
open(11,file='converged')
! Initialize ds (experiment with this!)
do j=0,num_procs-2
   ds(j+1)=ds0+real(j,8)*h
end do
! Set initial tangent vector
T=0d0
T(N)=1d0

! Read initial solution
call init_sol(z,init_fail)
! Check if all initializations finished successfully
call mpi_allreduce(init_fail,fail,1,MPI_LOGICAL,MPI_LOR,MPI_COMM_WORLD,ierr)
if(fail) print *,'Problem with the initialization, exiting...'

if(.not.(fail)) then
   print '(a20,10(1x,e10.3))','Current step sizes:',ds
   step=0
   ! Outter loop over points on the continuation curve
   outer: do while(step.lt.nsteps)
      extra_iteration = 0d0 !!! extra_iteration counts the number of extra iterations
      promising = .false. !!! if promising=true, then there is at least one slave corresponding to a residual that might still improve after one iteration
      max_iteration=10
      
      print '(a5,i4,a35)','Step ',step,' ----------------------------------'
      !  Set initial guesses
      do j=1,num_procs-1
         pred(:,j,1)=z + ds(j)* T
      end do
      !  Set initial approximate solutions equal to intial guesses
      pred(:,:,2)=pred(:,:,1)
      
      ! Inner loop over Newton-Raphson iterations
      inner: do while(extra_iteration.le.1)
	 
	 max_iteration = max_iteration - 1
	 if(max_iteration.lt.0) then
	         print *,'No convergence, exiting...'
		 exit outer
	 end if

         ! Send the predictions to the slaves
         do k=1,num_procs-1
            call MPI_SEND(pred(:,k,:),2*(N+1),MPI_DOUBLE_PRECISION,k, DEFAULT_TAG, MPI_COMM_WORLD, ierr)
         end do
         call mpi_bcast(T,N+1,MPI_DOUBLE_PRECISION,0,MPI_COMM_WORLD,ierr)

         ! Receive the results
         slave_trouble=.false.
         do k=1,num_procs-1
            call MPI_RECV(pred(:,k,2),N+1,MPI_DOUBLE_PRECISION,k, MPI_ANY_TAG, MPI_COMM_WORLD, status, ierr)
            ! Check tag for any reported allocation trouble
            received_tag = status(MPI_TAG)
            if(received_tag.eq.OUT_OF_MEM_TAG) slave_trouble=slave_trouble .or. .true.
            call MPI_RECV(r(k),1,MPI_DOUBLE_PRECISION,k, MPI_ANY_TAG, MPI_COMM_WORLD, MPI_STATUS_IGNORE, ierr)
         end do
         ! If any of the slaves failed to allocate, exit...
         if(slave_trouble) exit outer

         do k=1,num_procs-1
            print '(a5,i2,a3,e10.3,a3,i3,a10,e10.3)','Proc ',k,' ds=',ds(k),' It ',j,' residual ',r(k)
         end do
         
 	!! if the residual corresponding to the largest step size converged, then dont do another inner iteration
 	if(r(num_procs-1).lt.tol) then
            exit inner
	end if

    	do j=1:num_procs-1
		if(r(j).lt.tol) then
			max_converged=j   !!! if any of the slaves converged store the last index

		else if(tol.lt.r(j) .and. r(j)<tol**0.5) then
			promising=.true.
			ds(j)=ds0+real(j,8)*0.3

		else if(tol**0.5.lt.r(j) .and. r(j)<tol**0.25) then
			promising=.true.
			ds(j)=ds0+real(j,8)*0.3
		
		end if
	end do
          
	!! if some residuals converge but no other residuals can be improved, then take the largest one  
	if(.not.(promising) .and. max_converged.gt.0) then
		ds0=ds(max_converged)
		exit inner
	end if

    !!! if one extra iteration has already been done and at least one of the residuals is less than the tolerance...
    if(extra_iteration.eq.1 .and. max_converged.gt.0) then
        ds0=ds(max_converged)           !!! set the new base step size equal to the largest step size whose residual converged
        exit inner				        !!! dont do an extra iteration
    end if

	!! if there's a chance to improve some of the residuals further and there's at least one convergent residual
 	if(promising .and. max_converged.gt.0) then
		extra_iteration=extra_iteration+1
	end if
	
	!!! that is, if none of the slaves yielded a residual less than the set tolerance.
	if(max_converged.eq.0) then			
		ds0=0.5*ds0				!!! reduce the size of the smallest/base step size. we can play with this update for ds0.
	end if

      end do inner

	! Recompute tangent
	T=(pred(:,1,2)-z)/sqrt(sum((pred(:,1,2)-z)**2))
	! Set current point to converged approximate solution
	z=pred(:,1,2)
	! Increase step counter
	step=step+1
	! Write date to disk
	write(11,'(3(1x,e14.7))') z
	do j=0,num_procs-2
		ds(j+1)=ds0+real(j,8)*h
	end do

   end do outer
end if
! Close file
close(11)

! Send exit tag to slaves
call stop_slaves
deallocate(T,pred,r,z,ds)

return
end subroutine master

subroutine stop_slaves
use globals
implicit none
integer :: k,ierr
do k=1,num_procs-1
   call MPI_SEND(void,1,MPI_DOUBLE_PRECISION,k, EXIT_TAG, MPI_COMM_WORLD, ierr)
end do
return
end subroutine stop_slaves
