using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    public class GeometricBodyController
    {
        public GeometricBody biggestVolume(List<GeometricBody> bodies)
        {
            GeometricBody maxVolume = bodies[0];
            foreach (GeometricBody body in bodies)
            {
                if (maxVolume.getVolume() < body.getVolume())
                {
                    maxVolume = body;
                }
            }
            return maxVolume;
        }
        public GeometricBody biggestSurface(List<GeometricBody> bodies)
        {
            GeometricBody maxSurface = bodies[0];
            foreach (GeometricBody body in bodies)
            {
                if (maxSurface.getSurface() < body.getSurface())
                {
                    maxSurface = body;
                }
            }
            return maxSurface;
        }
    }
}