using System;

namespace lab7
{
    class Receptionist : Front_Desk_Staff
    {
        public Receptionist(DateTime joined, string[] education, string[] certification, string[] languages) : base(joined, education, certification, languages)
        {
        }
    }
}
