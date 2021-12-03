// 1. Implement the following class hierarchy and define as explained the objects:
//2. Base Class GeometricBody with the following abstract methods - getSurface(), getVolume() which should return the surface  and the volume of some figure.
//3. Implement the following child classes of GeometricBody - Cub, Sphere, Parallelepiped. (Each one is forced to implement the getSurface ad getVolume methods).
//In main: create by a object of each type of GeometricBody and put all of them in a array of GeometricBody's.__
//1. Create a class GeometricBodyController which has a method which gets as parameter a list of GeometricBody's and return the one with the biggest Volume.
//2. Create another method which does the same but that gives the body with the biggest Surface.
//3. In main call the method from this GeometricBodyController and give as parameter the list of bodies created in task1 and print in console the result.
//1. Change the abstract class GeometricBody to a interface and resolve any error if occured.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cub cube = new Cub(4);
            Sphere sfera = new Sphere(3);
            Parallelepiped paralelipiped = new Parallelepiped(2,4,3);

            Console.WriteLine("  Surface:");
            Console.WriteLine($"Cub: {cube.getSurface()}\nSphere: {sfera.getSurface()}\nParallelepiped: {paralelipiped.getSurface()}");

            Console.WriteLine("  Volume:");
            Console.WriteLine($"Cub: {cube.getVolume()}\nSphere: {sfera.getVolume()}\nParallelepiped: {paralelipiped.getVolume()}");

            List<GeometricBody> geometricBodies = new List<GeometricBody>();
            geometricBodies.Add(cube);
            geometricBodies.Add(sfera);
            geometricBodies.Add(paralelipiped);

            GeometricBodyController geometricBodyContr = new GeometricBodyController();

            Console.WriteLine("The biggest surface: " + geometricBodyContr.biggestSurface(geometricBodies));
            Console.WriteLine("The biggest volume: " + geometricBodyContr.biggestVolume(geometricBodies));


        }
    }
}