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
        public static void Push(int x, Queue<int> obj1)
        {
            obj1.Enqueue(x);
        }

        public static void Pop(Queue<int> obj1)
        {
            obj1.Dequeue();
        }

        public static void Push(string x, Queue<string> obj2)
        {
            obj2.Enqueue(x);
        }

        public static void Pop(Queue<string> obj2)
        {
            obj2.Dequeue();
        }

        static void Main(string[] args)
        {
            Queue<int> obj1 = new Queue<int>();
            Queue<string> obj2 = new Queue<string>();
            
            Push(10, obj1);
            Push(20, obj1);
            Push(30, obj1);
            Push(40, obj1);
            Push(50, obj1);

            Push("H", obj2);
            Push("e", obj2);
            Push("l", obj2);
            Push("l", obj2);
            Push("o", obj2);
            Push("!", obj2);

            foreach (int x in obj1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            

            foreach(string x in obj2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            Console.WriteLine("The number of elements in the First Queue " + obj1.Count);
            Console.WriteLine("The number of elements in the Second Queue " + obj2.Count);
            Pop(obj1);
            Pop(obj2);
            Pop(obj2);

            foreach (int x in obj1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            foreach (string x in obj2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            Console.WriteLine("The number of elements in the First Queue " + obj1.Count);
            Console.WriteLine("The number of elements in the Second Queue " + obj2.Count);
           
        }

    }
}
