using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab7
{
    class Departament
    {
        public string NameDep {get; set;}
        List<Staff> Staff = new List<Staff>();
        public List<Staff> GetSetStaff
        {
            get { return Staff; }
            set { Staff = value; }
        }
        public Departament(string name, string address, string phone) 
        {
        }

        public void Print_Depart()
        {
            Console.WriteLine("Name: " + this.NameDep);
            foreach (Staff X in this.GetSetStaff)
            {
                Console.WriteLine("Joined: " + X.joined);
                Console.Write("Education: ");
                Console.WriteLine( String.Join(", ", X.education));
                Console.Write("Certification: ");
                Console.WriteLine( String.Join(", ", X.certification));
                Console.Write("Languages: ");
                Console.WriteLine( String.Join(", ", X.languages));
            }
        }

    }
}
