using System;

namespace lab6
{
    class F: E
    {
        protected String f;
        public F(String a, String b, String c, String d, String e, String f, X x): base(a, b, c, d, e, x)
        {
            this.f = f;
        }
        
    }
}
