using System;

namespace lab7
{
    class Doctor : Operations_Staff
    {
        private string[] specialty;
        private string[] locations;

        public Doctor(string[] specialty, string[] locations): base(specialty, locations)
        {
            this.specialty = specialty;
            this.locations = locations;
        }
    }
}
