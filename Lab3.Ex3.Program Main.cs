using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3.ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a queue of capacity 5
            Queue q1 = new Queue(5);

            //inserting elements in the queue
            q1.Push(10);
            q1.Push(20);
            q1.Push(30);
            q1.Push(40);
            q1.Push(50);
            
            //print Queue elements
            Console.Write(" ");
            q1.Print();
            q1.IsEmpty();
            q1.IsFull();

            q1.Pop();
            q1.Pop();
            q1.Pop();
            Console.WriteLine("\n After modifications: ");
            Console.Write(" ");
            q1.Print();
            q1.IsEmpty();
            q1.IsFull();

            q1.Pop();
            q1.Pop();
            Console.WriteLine("\n After modifications: ");
            Console.Write(" ");
            q1.IsEmpty();
        }

    }
}
