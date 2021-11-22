using System;

namespace lab7
{
    class Surgical_Technologist : Technologist
    {
        public Surgical_Technologist(DateTime joined, string[] education, string[] certification, string[] languages) : base(joined, education, certification, languages)
        {
        }
    }
}
