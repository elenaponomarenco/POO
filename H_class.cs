using System;

namespace lab6
{
    class H: G
    {
        protected String h;
        private X x = new X("xxx => class H");
        public H(String a, String b, String c, String d, String e, String f, String g, String h, X x): base(a, b, c, d, e, f, g, x)
        {
            this.h = h;
        }
        
    }
}
