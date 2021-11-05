using System;

namespace lab6
{
    class J: I
    {
        protected String j;
        public J(String a, String b, String c, String d, String e, String f, String g, String h, String i, String j, X x): base(a, b, c, d, e, f, g, h, i, x)
        {
            this.j = j;
        }
        public string printClasses()
        {
            return a+b+c+d+e+f+g+h+i+j+x.X_get();
        }
    }
}
