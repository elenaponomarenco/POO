//Implement the classes in any OOP progamming language according to the class diagram
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;


namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Departament> List_Depart = new List<Departament>();
            Departament First_Dep = new Departament("Springfield Hospital", "Lawn Ln, Springfield, Chelmsford CM1 7GU, United Kingdom", "+44 1245 200307");
            First_Dep.NameDep = "Microbiology";

            Departament Second_Dep = new Departament("Springfield Hospital", "Lawn Ln, Springfield, Chelmsford CM1 7GU, United Kingdom", "+44 1245 200307");
            Second_Dep.NameDep = "Cardiology";
            List_Depart.Add(First_Dep);
            List_Depart.Add(Second_Dep);

            List<Hospital> List_Hosp = new List<Hospital>();
            Hospital Hosp_nr1 = new Hospital("Springfield Hospital", "Lawn Ln, Springfield, Chelmsford CM1 7GU, United Kingdom", "+44 1245 200307");
            List_Hosp.Add(Hosp_nr1);
            Hosp_nr1.GetSetDepart = List_Depart;
            Hosp_nr1.Print_Hospital();

            List<Staff> List_Staff = new List<Staff>();
            Staff First_Staff = new Staff(new DateTime(2015, 03, 20), new string[] {"Harvard University"}, new string[] {"Board certification", "Postbaccalaureate Certificate"}, new string[] {"English", "Spanish", "French"});
            List_Staff.Add(First_Staff);

            // Staff ded = new Person("Medical assistant", "John", "Jerald", "Smith", new DateTime(1972, 05, 01), "Male", "52-54 Spital St, Dartford DA1 2DT, United Kingdom", "+441322280050", List_Hosp);

            First_Dep.GetSetStaff = List_Staff;
            First_Dep.Print_Depart();

            List<Patient> Patients = new List<Patient>();
            List<Operations_Staff> Oper_Staff = new List<Operations_Staff>();

            Patient Patient1 = new Patient("0123", "Mark", "Connor", "Wilson", "Mark Connor Wilson", "male", new DateTime(2001, 11, 17), 20, new DateTime(2021, 02, 20), "Cyclospora", new string[] {"a combination of antibiotics called trimethoprim-sulfamethoxazole (TMP-SMX)"}, new string[] {"Pollen", "Dust", "Cats"}, new string[] {"should wash their hands often to prevent the spread of infection"});
            Patients.Add(Patient1);

            Patient1 = new Patient("0143", "Amanda", "Kasey", "Thompson", "Amanda Kasey Thompson", "male", new DateTime(1997, 10, 03), 24, new DateTime(2021, 10, 25), "Conjunctivitis", new string[] {"ophthalmic antibiotic eyedrops or ointments", " antihistamines", "decongestants"}, new string[] {"Penicillin", "Ibuprofen"}, new string[] {"Stop wearing contact lenses", "Try eyedrops", "Apply a compress to your eyes"});
            Patients.Add(Patient1);

            Patient1.GetSetPatients = Patients;
            Patient1.Print_Patient();
            // Console.ReadLine();
        }
    }
}
