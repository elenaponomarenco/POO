using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab7
{
    class Operations_Staff : Staff
    {
        List<Patient> Patients = new List<Patient>();
        public string OpStaff {get; set;}
        public Operations_Staff(DateTime joined, string[] education, string[] certification, string[] languages) : base(joined, education, certification, languages)
        {
        }
        public Operations_Staff(string[] specialty, string[] locations) : base(specialty, locations)
        {
        }
    }
}
