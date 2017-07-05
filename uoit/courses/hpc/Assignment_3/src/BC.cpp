/* For implementing the periodic boundary conditions */

#include "LangDyn_2D_Inter_PBC_DD.h"

/// Implements the periodic boundary conditions
void impose_BC(Particle particles[]) {
	int dumpster = param_d * param_d;
	int L2 = param_l / 2;

	for (int k = 0; k < param_n; k++) {

		// particle out of domain (in the dumpster)
		if (particles[k].sector == dumpster)
			continue;

		// particle outside the domain from light
		if (particles[k].x > L2)
			particles[k].x -= param_l;

		// particle outside the domain from left
		else if (particles[k].x < -L2)
			particles[k].x += param_l;

		// particle outside the domain from bottom
		if (particles[k].y > L2)
			particles[k].y -= param_l;

		// particle outside the domain from top
		else if (particles[k].y < -L2)
			particles[k].y += param_l;
	}
}