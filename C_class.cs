using System;

namespace lab6
{
    class C: B
    {
        protected String c;
        public C(String a, String b, String c, X x): base(a, b, x)
        {
            this.c = c;
        }
        
    }
}
