using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    public class Parallelepiped: GeometricBody
    {
        public double a;
        public double b;
        public double c;
            
        public Parallelepiped(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        
        public  double getSurface()
        {
            return (2*a*b) + (2*b*c) + (2*a*c);
        }
        public  double getVolume()
        {
            return a*b*c;
        }
    }
}