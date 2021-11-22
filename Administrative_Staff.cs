using System;

namespace lab7
{
    class Administrative_Staff: Staff
    {
        public Administrative_Staff(DateTime joined, string[] education, string[] certification, string[] languages) : base(joined, education, certification, languages)
        {
        }
    }
}
