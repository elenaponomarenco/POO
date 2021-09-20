/*
 * _Advanced Level_ (mark 7 || 8):
    - Implement a program where you should create and and modify the following objects: `university` and `student`. You should be able to create students that have name, age and mark (from their courses) and also to create universities which have name, foundationYear and a list of students created earlier.
    
  - _Advanced Level_ (mark 9 || 10):
    - In main program you should be able to create 3 universities with some students in it and calculate the average media between them and print the result in console.
*/
using System;
using System.Collections.Generic;

namespace ex2.Lab2
{
    class Program
    {
        public static void Media(Universitate a)
        {
            float sum = 0;
            int count = 0;
            float media;

            count = a.Students.Count;
            foreach (var st in a.Students)
            {
                sum += st.Mark;
            }
            media = sum / count;

            Console.WriteLine($"Media pentru {a.Name} este {media}");
        }
        static void Main(string[] args)
        {
            Universitate UTM = new Universitate()
            {
                Name = "UTM",
                FoundationYear = 1974,
                Students = new List<Student> 
                {
                    new Student()
                    {
                        Name="Elena",
                        Age = 18,
                        Mark = 8,
                    },

                    new Student()
                    {
                        Name = "Ana",
                        Age  = 20,
                        Mark = 10
                    },
                },
            };

            Universitate USM = new Universitate()
            {
                Name = "USM",
                FoundationYear = 1964,
                Students = new List<Student>
                {
                    new Student()
                    {
                        Name="Maria",
                        Age = 18,
                        Mark = 9,
                    },

                    new Student()
                    {
                        Name = "Marin",
                        Age  = 21,
                        Mark = 7
                    },
                },
            };

            Universitate ASEM = new Universitate()
            {
                Name = "ASEM",
                FoundationYear = 1970,
                Students = new List<Student>
                {
                    new Student()
                    {
                        Name="Marcela",
                        Age = 20,
                        Mark = 8,
                    },

                    new Student()
                    {
                        Name = "Petru",
                        Age  = 19,
                        Mark = 5
                    },
                },
            };
            Media(UTM);
            Media(USM);
            Media(ASEM);
        }

    } 
}
