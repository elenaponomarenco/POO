using System;

namespace lab7
{
    class Front_Desk_Staff : Administrative_Staff
    {
        public Front_Desk_Staff(DateTime joined, string[] education, string[] certification, string[] languages) : base(joined, education, certification, languages)
        {
        }
    }
}
