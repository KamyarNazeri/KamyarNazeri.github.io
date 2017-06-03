! Module for MKL FFT implementation, used by the slaves for the evaluation of the BVP
module fft
use globals
use MKL_DFTI
implicit none
integer :: fft_status = 0, ignored_status
type(DFTI_DESCRIPTOR), POINTER :: hand
contains
subroutine setup_fft(ierr)
integer :: ierr,n
ierr=0
hand => null()
fft_status = DftiCreateDescriptor(hand, DFTI_DOUBLE, DFTI_REAL, 1, m)
  if (0 /= fft_status) then
     ierr=1
     return
  end if

fft_status = DftiSetValue(hand, DFTI_PLACEMENT, DFTI_NOT_INPLACE)

  if (0 /= fft_status) then
     ierr=1
     return
  end if
fft_status = DftiSetValue(hand, DFTI_CONJUGATE_EVEN_STORAGE,                   &
                        DFTI_COMPLEX_REAL) 

fft_status = DftiSetValue(hand, DFTI_PACKED_FORMAT, DFTI_PACK_FORMAT) ! (a_0,Re(a_1),Im(a_1),...,Re(a_n/2-1),Im(a_n/2-1),Re(a_n/2))

fft_status = DftiSetValue(hand, DFTI_BACKWARD_SCALE, 1d0/real(m,8))

  if (0 /= fft_status) then
     ierr=1
     return
  end if
fft_status = DftiCommitDescriptor(hand)

  if (0 /= fft_status) then
     ierr=1
     return
  end if

return
end subroutine setup_fft

subroutine teardown_fft
ignored_status = DftiFreeDescriptor(hand)

return
end subroutine teardown_fft
end module fft
