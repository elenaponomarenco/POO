using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab7
{
    class Patient : Person
    {
        private string id;
        private string givenName;
        private string middleName;
        private string familyName;
        private string name;
        private string gender;
        private DateTime birthDate;
        private int age;
        private DateTime accepted;
        private string sickness;
        private string[] prescriptions;
        private string[] allergies;
        private string[] specialReqs;

        public Patient(string id, string givenName, string middleName, string familyName, string name, string gender, DateTime birthDate, int age, DateTime accepted, string sickness, string[] prescriptions, string[] allergies, string[] specialReqs)
        : base(id, givenName, middleName, familyName, name, gender, birthDate, age, accepted, sickness, prescriptions, allergies, specialReqs)
        {
            this.id = id;
            this.name = givenName +" "+ middleName +" "+ familyName;
            this.gender = gender;
            this.birthDate = birthDate;
            this.age = age;
            this.accepted = accepted;
            this.sickness = sickness;
            this.prescriptions = prescriptions;
            this.allergies = allergies;
            this.specialReqs = specialReqs;
        }

        List<Patient> Patients = new List<Patient>();
        List<Operations_Staff> Oper_Staff = new List<Operations_Staff>();
        public List<Patient> GetSetPatients
        {
            get {return Patients;}
            set {Patients = value;}
        }
        public List<Operations_Staff> GetSetOper_Staff
        {
            get {return Oper_Staff;}
            set {Oper_Staff = value;}
        }

        public void Print_Patient()
        {
            Console.WriteLine("\n    *****  Patient  *****");
            foreach(Patient p in Patients)
            {
                Console.WriteLine("\nID: " + p.id);
                Console.WriteLine("Full Name: " + p.name);
                Console.WriteLine("Gender: " + p.gender);
                Console.WriteLine("Birthday: " + p.birthDate);
                Console.WriteLine("Age: " + p.age);
                Console.WriteLine("Accepted: " + p.accepted);
                Console.WriteLine("Sickness: " + p.sickness);
                Console.Write("Prescriptions: ");
                Console.WriteLine(String.Join(", ",p.prescriptions));
                Console.Write("Allergies: ");
                Console.WriteLine(String.Join(", ",p.allergies));
                Console.Write("SpecialReqs: ");
                Console.WriteLine(String.Join(", ",p.specialReqs)); 
            }
            // Console.WriteLine("*****Operations Staff*****");
            // foreach(Operations_Staff OpS in Oper_Staff)
            // {
            //     Console.WriteLine(OpS.OpStaff);
            // }
        }
    }
}
