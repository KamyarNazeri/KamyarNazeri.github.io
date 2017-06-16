#ifndef LANGEVIN
#define LANGEVIN


extern int param_n;             // number of particles
extern int param_d;             // linear number of sectors (total d^2)
extern double param_l;          // domain size
extern double param_tmax;       // total time
extern double param_dt;         // time step size
extern double param_kT;         // total energy
extern double param_g;          // drag coefficient
extern double param_m;          // mass
extern double param_sigma;      // WCA potential parameters
extern double param_eps;        // WCA potential parameters
extern double param_rc;         // range of interaction

const int NEIGHBORS = 9;        // number of sector's neighbors 



/// Represents a particle (location, velocity and acceleration)
struct Particle {
	double x;                   // position (x)
	double y;                   // position (y)
	double vx;                  // velocity (x)
	double vy;                  // velocity (y)
	double vhx;                 // velocity verlet (x)
	double vhy;                 // velocity verlet (y)
	double ax;                  // acceleration (x)
	double ay;                  // acceleration (y)
	double init_x;              // initial position (x)
	double init_y;              // initial position (y)
	double real_x;              // real position without BC (x)
	double real_y;              // real position without BC (y)
	double init_vx;             // initial velocity (x)
	double init_vy;             // initial velocity (y)
	int sector;                 // number of the sector

	// initialize particle attributes upon creation
	Particle() : x(0), y(0), vx(0), vy(0), ax(0), ay(0), init_x(0), init_y(0), init_vx(0), real_x(0), real_y(0), init_vy(0), sector(0) { }
};



/// Represents a neighboring sector
struct Neighbor {
	int sector;                 // number of the sector in the typewriter index
	int offsetX;                // x offset of the neighboring sector when considering boundary condision (-l, 0, l)
	int offsetY;                // y offset of the neighboring sector when considering boundary condision (-l, 0, l)

	// initialize neighbor attributes upon creation
	Neighbor() : sector(0), offsetX(0), offsetY(0) {}
};



/// Represents a sector
struct Sector {
	int num;                        // number of the sector in the typewriter index
	int start;                      // start index of the particles in the sector
	int particles;                  // number of the particles in the sector
	Neighbor neighbors[NEIGHBORS];  // array of the neighboring sectors

	// initialize sector attributes upon creation
	Sector() : num(0), start(0), particles(0) {}
};



/// Initialize MKL random numbers generator
void initialize_RNG();

/// Finalize MKL random numbers generator
void finalize_RNG();

/// Creates 'n' random numbers with normal distribution and standard deviation 'sig' in the array 'arr'
void RNG_Gaussian(double *arr, int n, double sig);

/// Creates 'n' random numbers with uniform distribution ranging from 'a' to 'b' in the array 'arr'
void RNG_Uniform(double *arr, int n, double a, double b);




/// Implements the periodic boundary conditions
void impose_BC(Particle particles[]);

/// Initialize particles coordination and velocity
void initialize_particles(Particle particles[]);

/// Initialize Langevin-Dynamics input parameters
void initialize_parameters();




/// Order the list of positions by sector, returns the number of lost particles
void order(Sector sectors[], Particle particles[]);

/// Creates list of indices of neighboring sectors
void neighborlist(Sector sectors[]);



#endif //LANGEVIN
