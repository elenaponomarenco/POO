using System;

namespace lab7
{
    class Technician : Technical_Staff
    {
        public Technician(DateTime joined, string[] education, string[] certification, string[] languages) : base(joined, education, certification, languages)
        {
        }
    }
}
