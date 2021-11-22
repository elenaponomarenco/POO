using System;

namespace lab7
{
    class Nurse : Operations_Staff
    {
        public Nurse(DateTime joined, string[] education, string[] certification, string[] languages) : base(joined, education, certification, languages)
        {
        }
    }
}
