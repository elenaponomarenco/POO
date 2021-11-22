using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace lab7
{
    class Person
    {
        public string title;
        public string givenName;
        public string middleName;
        public string familyName;
        public string name;
        public DateTime birthDate;
        public string gender;
        public string homeAddress;
        public string phone;
        public List<Hospital> Hospitals = new List<Hospital>();

        public Person(string title, string givenName, string middleName, string familyName, DateTime birthDate, string gender, string homeAddress, string phone)
        {
            this.title = title;
            this.givenName = givenName;
            this.middleName = middleName;
            this.familyName = familyName;
            this.name = givenName + middleName + familyName;
            this.birthDate = birthDate;
            this.gender = gender;
            this.homeAddress = homeAddress;
            this.phone = phone;
        }

        public void Print_Person()
        {
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Full Name: " + this.name);
            Console.WriteLine("Birthday: " + this.birthDate);
            Console.WriteLine("Gender: " + this.gender);
            Console.WriteLine("Address: " + this.homeAddress);
            Console.WriteLine("Phone: " + this.phone);
        }
        public Person(string id, string givenName, string middleName, string familyName, string name, string gender, DateTime birthDate, int age, DateTime accepted, string sickness, string[] prescriptions, string[] allergies, string[] specialReqs)
        {
        }

        public Person(DateTime joined, string[] education, string[] certification, string[] languages)
        {
        }

        public Person(string[] specialty, string[] locations)
        {
        }
    }
}
