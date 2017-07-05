/*
To compile the code:
icc *.cpp -o res -mkl

To compile the code with OpenMP:
icc *.cpp -o res -mkl -fopenmp
 */

#include <omp.h>
#include <stdio.h>
#include <math.h>
#include <ctime>
#include <string>
#include <iostream>
#include "LangDyn_2D_Inter_PBC_DD.h"


using namespace std;


/// Starts Langevin-Dynamics
void startLangevinDynamics(Sector sectors[], Particle particles[]) {
	FILE *trajectories, *means;

	means = fopen("means", "w");
	trajectories = fopen("trajectories", "w");


	double t = 0;                                               // time step
	double pref1 = param_g;                                     // drag coefficient
	double pref2 = sqrt(2 * param_kT * param_g / param_dt);     // C (fluctuation dissipation theorem)
	double avg_x2 = 0;                                          // sum of X's mean-square
	double avg_y2 = 0;                                          // sum of Y's mean-square
	double* ran = new double[2 * param_n];                      // random force

	int dumpster = param_d * param_d;                           // dumpster's index
	int total_particles = param_n;                              // total number of particles at the start of the simulation
	int total_it = 0;                                           // total number of iterations
	int total_calc = 0;                                         // total number of calculating distance between each two particles
	int total_collision = 0;                                    // total number of times particles step onto each other
	long total_interac = 0;                                     // total number of times particles expose to interaction force

	clock_t begin = clock();

#if defined(_OPENMP)
	double wall_time_start = omp_get_wtime();
	//omp_set_num_threads(2);
#endif

	// iterate time
	while (t < param_tmax) {
		total_it++;
		t += param_dt;
		avg_x2 = 0;
		avg_y2 = 0;


		// calculate particles location and velocity-verlet
		for (int i = 0; i < param_n; i++) {
			Particle *p = &particles[i];

			// particle out of domain (in the dumpster)
			if (p->sector == dumpster) continue;

			p->vhx = p->vx + 0.5 * p->ax * param_dt;
			p->vhy = p->vy + 0.5 * p->ay * param_dt;

			p->x += p->vhx * param_dt;
			p->y += p->vhy * param_dt;

			p->real_x += p->vhx * param_dt;
			p->real_y += p->vhy * param_dt;
		}


		impose_BC(particles);
		order(sectors, particles);

        // remove number of particles in the dumpster from the actual particles count
        param_n = total_particles - sectors[param_d*param_d].particles;
        if (param_n <= 0)
            break;

        RNG_Gaussian(ran, param_n * 2, 1);



		// calculate particles acceleration and mean-square displacement
		for (int i = 0; i < param_n; i++) {
			Particle *p = &particles[i];

			// particle out of domain (in the dumpster)
			if (p->sector == dumpster) continue;

			p->ax = 0;
			p->ay = 0;

			p->ax += (-pref1 * p->vhx + pref2 * ran[i]) / param_m;
			p->ay += (-pref1 * p->vhy + pref2 * ran[i + 1]) / param_m;

			avg_x2 += pow(p->real_x - p->init_x, 2);
			avg_y2 += pow(p->real_y - p->init_y, 2);
		}



#if defined(_OPENMP)
#pragma omp parallel for
#endif
		// calculate force and acceleration: loop over sectors
		for (int s1 = 0; s1 < dumpster; s1++) {
			Sector sec = sectors[s1];

			// loop over particles in the sector
			for (int i = sec.start; i < sec.start + sec.particles; i++) {

				// loop over neighbors of the sector
				for (int s2 = 0; s2 < NEIGHBORS; s2++) {
					Neighbor neighbor = sec.neighbors[s2];
					Sector nsec = sectors[neighbor.sector];

					//loop over particles in neighbor
					for (int j = nsec.start; j < nsec.start + nsec.particles; j++) {

						if (i == j) continue;

						total_calc++;
						double rx = particles[j].x - particles[i].x - neighbor.offsetX;
						double ry = particles[j].y - particles[i].y - neighbor.offsetY;
						double dist = sqrt(rx*rx + ry*ry);

						if (dist < param_rc) {
							total_interac++;
							double F = 4 * param_eps * (-12 * pow(param_sigma, 12) / pow(dist, 13) + 6 * pow(param_sigma, 6) / pow(dist, 7));
							double jump = 0.5 * param_dt * param_dt * F / param_m;

							// particle jumps outside the domain
							if (fabs(jump) > param_l / 2) 
								total_collision++;

							particles[i].ax += F * rx / (dist * param_m);
							particles[i].ay += F * ry / (dist * param_m);
						}
					}
				}
			}
		}



#if defined(_OPENMP)
#pragma omp parallel sections
#endif
		{
			// calculate velocity 
#if defined(_OPENMP)
#pragma omp section
#endif
			{
				for (int i = 0; i < param_n; i++) {

					// particle out of domain (in the dumpster)
					if (particles[i].sector == dumpster) continue;

					particles[i].vx = particles[i].vhx + 0.5 * particles[i].ax * param_dt;
					particles[i].vy = particles[i].vhy + 0.5 * particles[i].ay * param_dt;
				}
			}


			// write particles coordination
#if defined(_OPENMP)
#pragma omp section
#endif
			{
				for (int i = 0; i < param_n; i++)
					fprintf(trajectories, "%f %f\n", particles[i].x, particles[i].y);

				// write a new line
				fprintf(trajectories, " \n");
			}


			// write mean-square displacement
#if defined(_OPENMP)
#pragma omp section
#endif
			{
				fprintf(means, "%f %f\n", t, sqrt((avg_x2 + avg_y2) / param_n));
			}
		}
	}


#if defined(_OPENMP)
	double elapsed_secs = omp_get_wtime() - wall_time_start;
#else
	double elapsed_secs = double(clock() - begin) / CLOCKS_PER_SEC;
#endif

	cout << "n: " << total_particles << ", L: " << param_l << ", d = " << param_d << ", rc = " << param_rc << ", dt = " << param_dt << ", tmax = " << param_tmax << endl;
	cout << "Wall-Time: " << elapsed_secs << endl;
	cout << "Iterations: " << total_it << endl;
	cout << "Lost particles: " << total_particles - param_n << endl;
	cout << "Number of calculations: " << total_calc << endl;
	cout << "Number of interactions: " << total_interac << endl;
	cout << "Number of collisions: " << total_collision << endl;

	delete ran;
}



/// Program start
int main() {
	initialize_RNG();                                        // initialize MKL random number generator
	initialize_parameters();                                 // read input parameters from file

	Particle* particles = new Particle[param_n];             // create particles
	initialize_particles(particles);                         // initialize particles initial location and velocity

	Sector* sectors = new Sector[param_d * param_d + 1];    // create sectors. The last sector: dumpster
	neighborlist(sectors);                                  // initialize sectors and the neighbors' list

	impose_BC(particles);                                   // initial boundary condition test
	order(sectors, particles);                              // initial ordering of particles

	startLangevinDynamics(sectors, particles);              // start Langevin dynamics calculations

	finalize_RNG();                                          // dispose MKL random number generator
	delete particles;                                       // free memory
	delete sectors;                                         // free memory
	return 0;
}

