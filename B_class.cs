using System;

namespace lab6
{
    class B: A
    {
        protected String b;
        public B(String a, String b, X x): base(a, x) //"base." este echivalentul la "super()" 
        {
            this.b = b;
        }
        //base = este folosit pentru a accesa câmpuri, constructori și metode ale clasei de bază
    }
}
