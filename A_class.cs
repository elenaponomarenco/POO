using System;

namespace lab6
{
    class A
    {
        protected String a;
        // protected X x1 = new X("some name");
        protected X x = new X("xxx");
        public A(String a, X x){
            this.a = a;
            this.x = x;
        }
        public string A_get() {  return a;  }
        //"this." se referă la instanța curentă a clasei
    }
}
