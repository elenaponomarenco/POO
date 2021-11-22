using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab7
{
    class Staff: Person
    {
        public DateTime joined;
        public string[] education;
        public string[] certification;
        public string[] languages;
       

        public Staff(DateTime joined, string[] education, string[] certification, string[] languages): base(joined, education, certification, languages)
        {
            this.joined = joined;
            this.education = education;
            this.certification = certification;
            this.languages = languages;
        }
        public Staff(string[] specialty, string[] locations): base(specialty, locations)
        {
        }
    }
}
