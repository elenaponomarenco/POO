using System;

namespace lab6
{
    class D: C
    {
        protected String d;
        protected X x = new X("xxx => class D");
        public D(String a, String b, String c, String d, X x): base(a, b, c, x)
        {
            this.d = d;
        }
        
    }
}
