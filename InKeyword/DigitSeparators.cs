using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public static class DigitSeparators
    {
        public static void Test()
        {
            var x = 0x_badd_caed_aacd;
            var y = 1246_3654;
            var z = 0b1000_0001_1101;


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


        }

    }
}
