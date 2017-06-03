#include "iostream"
#include "stdio.h"
#include "math.h"
#include <algorithm>
#include "particle.h"
#include "stochastics.h"

using namespace std;


int n;                  // number of particles
double L;               // domain size
double tmax;            // total time
double dt;              // time step size
double kT;              // total energy
double g;               // drag coefficient
double m;               // mass
Particle *particles;    // particles


/// Parses input parameter and returns the corresponding number value
double parseInputParameter(int argc, char *argv[], string prefix, double defaultValue) {
    double result = 0;

    // loop through input arguments
    for (int i = 1; i < argc; i++) {
        int len = prefix.length();
        string arg_str = string(argv[i]);
        transform(arg_str.begin(), arg_str.end(), arg_str.begin(), ::tolower);

        // compare prefix ignoring case
        if (!string(argv[i]).compare(0, len, prefix)) {
            result = atof(&argv[i][len]);   // convert input string to number
        }
    }

    // input argument not found or invalid: default-value
    return result == 0 ? defaultValue : result;
}


/// Initialize Langevin-Dynamics input parameters
void initializeParameters(int argc, char *argv[]) {

    int param_n = parseInputParameter(argc, argv, "n", 10000);
    double param_l = parseInputParameter(argc, argv, "l", 10000);
    double param_tmax = parseInputParameter(argc, argv, "tmax", 3);
    double param_dt = parseInputParameter(argc, argv, "dt", 0.01);
    double param_kT = parseInputParameter(argc, argv, "kt", 1);
    double param_g = parseInputParameter(argc, argv, "g", 1);
    double param_m = parseInputParameter(argc, argv, "m", 1);

    n = param_n;
    L = param_l;
    tmax = param_tmax;
    dt = param_dt;
    kT = param_kT;
    g = param_g;
    m = param_m;

    cout << "Particles: " << n << endl;
    cout << "Domain Size: " << L << endl;
    cout << "Total Time: " << tmax << endl;
    cout << "Delta Time: " << dt << endl;
    cout << "KT: " << kT << ", m: " << m << ", gamma: " << g << endl;
}


/// Initialize particles and initial velocity
void initializeParticles() {
    double ran1[n], ran2[n];
    Stochastics st;
    particles = new Particle[n];                        // create array of particles

    st.create(ran1, n, sqrt(kT / m));                   // create random numbers for ran1
    st.create(ran2, n, sqrt(kT / m));                   // create random numbers for ran2

    for (int i = 0; i < n; i++) {
        particles[i].vx = sqrt(kT / (m)) * ran1[i];     // initial velocity x
        particles[i].vy = sqrt(kT / (m)) * ran2[i];     // initial velocity y
        particles[i].vix = particles[i].vx;             // save initial x velocity
        particles[i].viy = particles[i].vy;             // save initial y velocity
    }
}


/// Implements the periodic boundary conditions
void imposeBC(Particle *particle) {
    if (particle->x > L / 2)
        particle->x = (particle->x - L);

    else if (particle->x < -L / 2)
        particle->x = (particle->x + L);

    if (particle->y > L / 2) {
        particle->y = (particle->y - L);
    } else if (particle->y < -L / 2)
        particle->y = (particle->y + L);
}


/// Starts Langevin-Dynamics
void startLangevinDynamics() {
    Stochastics st;
    FILE *trajectories, *means, *forces, *autocorrelatios, *decay;

    means = fopen("means", "w");
    forces = fopen("forces", "w");
    trajectories = fopen("trajectories", "w");
    autocorrelatios = fopen("autocorrelatios", "w");


    double t = 0;
    double ran[2];                          // Random force
    double pref1 = g;                       // Drag coefficient
    double pref2 = sqrt(2 * kT * g / dt);   // C (fluctuation dissipation theorem)

    double vhx = 0;                         // Velocity Verlet X
    double vhy = 0;                         // Velocity Verlet Y

    double avg_x2 = 0;                      // Sum of X's square
    double avg_y2 = 0;                      // Sum of Y's square
    double vprodut = 0;                     // Sum of velocity products with correlation
    double vprodut_offset = 0;

    while (t < tmax) {
        t += dt;
        avg_x2 = 0;
        avg_y2 = 0;
        vprodut = 0;
        vprodut_offset = 0;

        for (int i = 0; i < n; i++) {

            Particle *p = &particles[i];
            vhx = p->vx + 0.5 * p->ax * dt;
            vhy = p->vy + 0.5 * p->ay * dt;

            p->x = p->x + vhx * dt;
            p->y = p->y + vhy * dt;

            imposeBC(p);

            st.create(ran, 2, 1);                   // Create random force
            p->ax = 0;                              // Add forces/m here if any
            p->ay = 0;                              // Add forces/m here if any

            p->ax = p->ax + (-pref1 * vhx + pref2 * ran[0]) / m;
            p->ay = p->ay + (-pref1 * vhy + pref2 * ran[1]) / m;

            p->vx = vhx + 0.5 * p->ax * dt;
            p->vy = vhy + 0.5 * p->ay * dt;

            avg_x2 += p->x * p->x;                  // Sum of X's square
            avg_y2 += p->y * p->y;                  // Sum of Y's square

            // calculating velocity autocorrelation
            vprodut_offset += (p->vix * p->vx + p->viy * p->vy);
            vprodut += (p->vix * p->vix + p->viy * p->viy);

            // write particles random force
            fprintf(forces, "%f %f\n", ran[0], ran[1]);

            // write particles coordination
            fprintf(trajectories, "%f %f\n", p->x, p->y);
        }

        // write a new line
        fprintf(trajectories, " \n");

        // write mean-square displacement
        fprintf(means, "%f %f\n", t, sqrt((avg_x2 + avg_y2) / n));

        // write velocity autocorrelation values
        fprintf(autocorrelatios, "%f %f %f\n", t, (vprodut_offset / vprodut), exp(-g * t / m));
    }
}


/// Program start
int main(int argc, char *argv[]) {
    initializeParameters(argc, argv);
    initializeParticles();
    startLangevinDynamics();

    return 0;
}


