using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public static class NonTrailingArguments
    {
        static void func(string arg1, string arg2)
        {

        }
        public static void Test()
        {
            func("ajhdg", arg2: "asdas");
            func(arg1: "ajhdg", "asdas");//Its 7.2 feature
            func(arg2: "ajhdg", arg1:"asdas");
        }

    }
}
