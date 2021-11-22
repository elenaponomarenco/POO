using System;

namespace lab7
{
    class Technologist : Technical_Staff
    {
        public Technologist(DateTime joined, string[] education, string[] certification, string[] languages) : base(joined, education, certification, languages)
        {
        }
    }
}
