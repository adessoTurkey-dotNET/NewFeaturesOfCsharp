using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public class Base
    {
        private string a;
        protected internal string b;
        private protected string c;

    }

    public class Derived : Base
    {
        public Derived()
        {
            //a = "sdk"; compile error
            b = "dekfd";
            c = string.Empty;
        }
    }
    public static class PrivateProtected
    {
        public static void Test()
        {
            var der = new Derived();

            der.b = "sdf";
            //der.c = string.Empty;Compile error

        }

    }
}
