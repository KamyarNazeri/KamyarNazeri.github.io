/* For implementing domain decomposition */

#include <math.h>
#include <stdlib.h>
#include <iostream>
#include "LangDyn_2D_Inter_PBC_DD.h"


using namespace std;

/// Order the list of positions by sector, returns the number of lost particles
void order(Sector sectors[], Particle particles[]) {
	int L2 = param_l / 2;                             // distance from the origin
	int start = 0;                                    // start index of each sector
	int sec_count = param_d*param_d;                  // total sectors
	double width = param_l / param_d;                 // sector's width

	Particle* copy = new Particle[param_n];           // allocate an array to copy particles (used in ordering)


	// reset all sectors prior assignment
	for (int s = 0; s < sec_count; s++) {
		sectors[s].start = 0;
		sectors[s].particles = 0;
	}


	// assign a sector to each particle
	for (int k = 0; k < param_n; k++) {

		// particle in domain, assign sector index 
		// use 'fabs' function to get the absolute value of the floating point
		if (fabs(particles[k].x) < L2 && fabs(particles[k].y) < L2) {
			int row = floor((particles[k].y + L2) / width);
			int col = floor((particles[k].x + L2) / width);
			int sec = row * param_d + col;

			particles[k].sector = sec;           // assign a sector to the particle
			sectors[sec].particles++;            // increment the number of particles in the sector
		}
		// particle outside bounds, put in dumpster
		else {
			particles[k].sector = sec_count;    // assign dumpster sector to the particles
			sectors[sec_count].particles++;     // increment the number of particles in the dumpster
		}

		copy[k] = particles[k];
	}


	// assign particles to sectors
	for (int s = 0; s <= sec_count; s++) {
		sectors[s].start = start;              // start: sum of previous particles count
		start += sectors[s].particles;         // accumulate previous particles count
		sectors[s].particles = 0;              // reset particles count. to be used in ordering
	}


	// order particles
	for (int k = 0; k < param_n; k++) {
		int sec = copy[k].sector;

		// reorder particles to match the sectors
		particles[sectors[sec].start + sectors[sec].particles] = copy[k];
		sectors[sec].particles++;
	}

	delete copy;
}


/// Initializes sectors and creates list of indices of neighboring sectors
void neighborlist(Sector sectors[]) {
	for (int s = 0; s < param_d*param_d; s++) {
		int nbr = 0;                            // neighbor's index
		int row = s / param_d;                  // sector's row
		int col = s % param_d;                  // sector's column
		sectors[s].num = s;                     // sector's number

		// finding sector's all 9 neighbors (including itself)
		for (int nrow = row - 1; nrow <= row + 1; nrow++) {
			for (int ncol = col - 1; ncol <= col + 1; ncol++) {

				int xfactor = (ncol + param_d) / param_d - 1;           // out of boundary: -1/1, inside domain: 0
				int yfactor = (nrow + param_d) / param_d - 1;           // out of boundary: -1/1, inside domain: 0

				sectors[s].neighbors[nbr].offsetX = xfactor * param_l;  // x offset for calculating particles distance
				sectors[s].neighbors[nbr].offsetY = yfactor * param_l;  // x offset for calculating particles distance

				// Compute typewriter index from chessboard indices: (row * sectors) + column
				sectors[s].neighbors[nbr].sector = (nrow - yfactor * param_d) * param_d + (ncol - xfactor * param_d);

				nbr++;
			}
		}
	}
}