using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab7
{
    class Hospital
    {
        public string name;
        public string address;
        public string phone;
        List<Person> Persons = new List<Person>();
        List<Departament> Departaments = new List<Departament>();

        public List<Person> GetSetPerson
        {
            get {return Persons;}
            set {Persons = value;}
        }
        public List<Departament> GetSetDepart
        {
            get {return Departaments;}
            set {Departaments = value;}
        }

        public Hospital(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public void Print_Hospital()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Address: " + this.address);
            Console.WriteLine("Phone: " + this.phone);
            foreach(Departament x in this.GetSetDepart)
            {
                Console.WriteLine("Departament: " + x.NameDep);
            }
        }
    }
}
