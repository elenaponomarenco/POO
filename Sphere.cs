using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    public class Sphere: GeometricBody
    {
        public double r;
            
        public Sphere(double r)
        {
            this.r = r;
        }

        public  double getSurface()
        {
            return 4*Math.PI*(r*r);
        }
        public  double getVolume()
        {
            return (4 * Math.PI * (r*r*r))/3;
        }
    }
}