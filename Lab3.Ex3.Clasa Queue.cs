using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.ex2
{
    class Queue
    {
        private static int Front { get; set; }
        private static int Rear { get; set; }
        private static int Capacity { get; set; }
        private static int[] queue { get; set; }

        public Queue(int size) //constructor cu parametru
        {
            Front = Rear = 0;
            Capacity = size;
            queue = new int[Capacity];
        }

        public Queue()  //constructor fara parametru
        {
            Front = Rear = 0;
            Capacity = int.MaxValue;
            queue = new int[Capacity];
        }

        // function to insert an element
        // at the rear of the queue
        public void Push(int data)
        {
            
            // check queue is full or not
            if (Capacity == Rear)
            {
                Console.WriteLine(" Queue is full ");
                return;
            }
            // insert element at the rear
            else
            {
                queue[Rear] = data;
                Rear++;
            }
            return;
        }
        // function to delete an element
        // from the front of the queue
        public void Pop()
        {
            // if queue is empty
            if (Front == Rear)
            {
                Console.WriteLine(" Queue is empty");
                return;
            }

            // shift all the elements from index 2 till rear
            // to the right by one
            else
            {
                for (int i = 0; i < Rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                // store 0 at rear indicating there's no element
                if (Rear < Capacity)
                    queue[Rear] = 0;

                // decrement rear
                Rear--;
            }
            return;
        }

        public void Print()
        {
            int i;
            if (Front == Rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }

            // traverse front to rear and print elements
            for (i = Front; i < Rear; i++)
            {
                Console.Write("{0} <- ", queue[i]);
            }
            Console.WriteLine("\n The number of elements in the Queue {0}\n", i);
            return;
        }

        public void IsFull()
        {
            if (Capacity == Rear)
            {
                Console.WriteLine(" Queue is full.");
                return;
            }
            else
            {
                Console.WriteLine(" Queue is not full yet.");
                return;
            }
        }
        public void IsEmpty()
        {
            if (Front == Rear)
            {
                Console.WriteLine(" Queue is empty.");
                return;
            }
            else
            {
                Console.WriteLine(" Queue is not empty.");
                return;
            }
        }
    }
}
