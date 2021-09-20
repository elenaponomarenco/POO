/*
 * _Basic Level_ (mark 5 || 6):
    - Create a program where you can manipulate a monitor object which has color, dimensions and resolution. 
    
    Perform the following steps: 
    
    1. Create a monitor.
    2. Update the monitor's properties.
    3. Create second monitor and then compare with first one created above.
*/
using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Monitor obj1 = new Monitor()
            {
                Color = "black",
                Dimension = 55,
                Resolution = 1080,
            };

            Monitor obj2 = new Monitor()
            {
                Color = "white",
                Dimension = 45,
                Resolution = 1080,
            };

            Compare(obj1, obj2);
        }

        public static void  Compare(Monitor x, Monitor y)
        {
            if (x.Color.ToLower() == y.Color.ToLower() && (x.Dimension == y.Dimension) && (x.Resolution == y.Resolution))
            {
                Console.WriteLine("Monitoarele sunt egale.");
            }
            else
            {
                Console.WriteLine("Monitoarele sunt diferite.");
            }

        }


    }
}
