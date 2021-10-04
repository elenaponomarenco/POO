using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Ex_1
{
    class Box
    {
        public float Height { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }

        public Box()
        {
            Height = 1;
            Width = 1;
            Depth = 1;
        }

        public Box(float value)
        {
            Height = value;
            Width = value;
            Depth = value;
        }

        public Box(float height, float width, float depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }
    }
}
