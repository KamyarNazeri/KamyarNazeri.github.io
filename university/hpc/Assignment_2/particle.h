/// Represents a particle (location, velocity and acceleration)
struct Particle {
    double x;           // position (x)
    double y;           // position (y)
    double vx;          // velocity (x)
    double vy;          // velocity (y)
    double ax;          // acceleration (x)
    double ay;          // acceleration (y)
    double vix;         // initial velocity (x)
    double viy;         // initial velocity (y)

    // initialize particle attributes upon creation
    Particle() : x(0), y(0), vx(0), vy(0), ax(0), ay(0), vix(0), viy(0) { }
};