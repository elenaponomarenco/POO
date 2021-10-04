using System;

namespace Lab3.Ex_1
{
    class Program
    {
        public static double Surface_Area(Box x)
        {
            return 2 * (x.Depth + x.Height + x.Width);
        }
        public static double Volume(Box x)
        {
            return x.Width * x.Height * x.Depth;
        }
        static void Main(string[] args)
        {
            Box Obj1 = new Box();
            Box Obj2 = new Box(2.5);
            Box Obj3 = new Box(2.5, 3.75, 4.2);

            Console.WriteLine("Box 1\n Width: {0}\n Height: {1}\n Depth: {2}", Obj1.Width, Obj1.Height, Obj1.Depth);
            Console.WriteLine("Box 2\n Width: {0}\n Height: {1}\n Depth: {2}", Obj2.Width, Obj2.Height, Obj2.Depth);
            Console.WriteLine("Box 3\n Width: {0}\n Height: {1}\n Depth: {2}", Obj3.Width, Obj3.Height, Obj3.Depth);
            Console.WriteLine("\n1) Surface Area of the box 1:  " + Surface_Area(Obj1));
            Console.WriteLine("2) Surface Area of the box 2:  " + Surface_Area(Obj2));
            Console.WriteLine("3) Surface Area of the box 3:  " + Surface_Area(Obj3));
            Console.WriteLine("\n1) Volume of the box 1:  " + Volume(Obj1));
            Console.WriteLine("2) Volume of the box 2:  " + Volume(Obj2));
            Console.WriteLine("3) Volume of the box 3:  " + Volume(Obj3));

        }
    }
}
