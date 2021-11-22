using System;

namespace lab7
{
    class Technical_Staff : Staff
    {
        public Technical_Staff(DateTime joined, string[] education, string[] certification, string[] languages) : base(joined, education, certification, languages)
        {
        }
    }
}
