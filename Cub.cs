using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    public class Cub : GeometricBody
    {
       public double a;

       public Cub(double a)
       {
           this.a = a;
       }

       public double getSurface()
       {
           return 6*(a*a);
       }
       public double getVolume()
       {
           return a*a*a;
       }
    }
}