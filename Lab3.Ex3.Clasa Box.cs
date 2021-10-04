using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Ex_1
{
    class Box
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public Box()
        {
            Height = 1;
            Width = 1;
            Depth = 1;
        }

        public Box(double value)
        {
            Height = value;
            Width = value;
            Depth = value;
        }

        public Box(double height, double width, double depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }
    }
}
