using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.ex2
{
    class Queue
    {
        public int Size { get; set; }
        public int[] Array { get; set; }

        public Queue(int value)
        {
            Size = 15;
        }
        public Queue()
        {
            Size = int.MaxValue;
        }
    }
}
