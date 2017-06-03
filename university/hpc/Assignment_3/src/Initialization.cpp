#include <stdio.h>
#include <iostream>
#include <fstream>
#include <string>
#include <math.h>
#include <stdlib.h>
#include "LangDyn_2D_Inter_PBC_DD.h"


using namespace std;

int param_n = 10000;            // number of particles
int param_d = 100;              // linear number of sectors (total d^2)
double param_l = 100;           // domain size
double param_tmax = 1;          // total time
double param_dt = 0.01;         // time step size
double param_kT = 1;            // total energy
double param_g = 1;             // drag coefficient
double param_m = 1;             // mass
double param_sigma = 0.1;       // WCA potential parameters
double param_eps = 0.001;       // WCA potential parameters
double param_rc = 1;            // range of interaction



/// Parses input parameter and returns the corresponding number value
double parseInputParameter(string prefix, double defaultValue) {
    ifstream ifs;
    ifs.open("init", ifstream::in);
	string line;

	int len = prefix.length();
	while (getline(ifs, line))
	{
		// line starts with the specified prefix

		if (!line.compare(0, len, prefix)) {

			// convert input string to number
			return atof(&line[len] + 1);
		}
	}

	return defaultValue;
}


/// Initialize Langevin-Dynamics input parameters
void initialize_parameters() {

	param_n = parseInputParameter("n", param_n);
	param_d = parseInputParameter("d", param_d);
	param_l = parseInputParameter("l", param_l);
	param_tmax = parseInputParameter("tmax", param_tmax);
	param_dt = parseInputParameter("dt", param_tmax);
	param_kT = parseInputParameter("kt", param_tmax);
	param_g = parseInputParameter("g", param_tmax);
	param_m = parseInputParameter("m", param_tmax);
	param_sigma = parseInputParameter("sigma", param_tmax);
	param_eps = parseInputParameter("eps", param_tmax);
	param_rc = param_sigma * pow(2, 1.0 / 6.0);

	if (param_d < 3) {
		cout << "Error: Invalid parameter d. Minimum value = 3" << endl;
		exit(EXIT_FAILURE);
	}

	if ((param_l / param_d) < param_rc) {
		cout << "Error: Invalid parameter d, L/d must be greater than the range of interaction. max d: " << (int)param_l / param_rc << endl;
		exit(EXIT_FAILURE);
	}
}


/// Initialize particles coordination and velocity
void initialize_particles(Particle particles[]) {
	int max = param_l / param_rc;                   // max number of particles in a row/column without collision
	int maxp = max * max;                           // max number of particles in the domain without collision

	if (param_n > maxp) {
		cout << "Error: Maximum number of particles reached. The maximum number of particles without interaction is " << maxp << endl;
		exit(EXIT_FAILURE);
	}

	int* pos = new int[maxp];                       // array of all possible positions in a mesh
	double* vel = new double[param_n * 2];          // array of random initial velocities
	double* ran = new double[maxp];                 // array of random initial locations

	RNG_Gaussian(vel, param_n * 2, sqrt(param_kT / param_m));       // create initial velicity random numbers
	RNG_Uniform(ran, maxp, 0, maxp);                                // create initial location random numbers


	// save all possible positions in the domain (without collision)
	for (int i = 0; i < maxp; i++) {
		pos[i] = i;
	}

	// Fisher-Yates shuffle positions
	for (int i = 0; i < maxp; i++) {
		int tmp = pos[i];
		int j = floor(ran[i]);

		pos[i] = pos[j];
		pos[j] = tmp;
	}

	// apply initial position and velicoty to all particles
	for (int i = 0; i < param_n; i++) {
		double x = (int)(pos[i] % max + 1) * param_rc - param_l / 2;
		double y = (int)(pos[i] / max + 1) * param_rc - param_l / 2;
		double vx = sqrt(param_kT / param_m) * vel[i];
		double vy = sqrt(param_kT / param_m) * vel[i + param_n];

		particles[i].x = x;                 // initial position x
		particles[i].y = y;                 // initial position y
		particles[i].real_x = x;            // save real x position
		particles[i].real_y = y;            // save real y position
		particles[i].init_x = x;            // save initial x position
		particles[i].init_y = y;            // save initial y position

		particles[i].vx = vx;               // initial velocity x
		particles[i].vy = vy;               // initial velocity y
		particles[i].init_vx = vx;          // save initial x velocity
		particles[i].init_vy = vy;          // save initial y velocity
	}

	delete pos;
	delete vel;
	delete ran;
}
