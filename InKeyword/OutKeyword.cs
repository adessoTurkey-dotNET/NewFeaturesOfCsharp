using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutKeyword
{
    static public class OutKeywordFunc
    {
        static public void Test()
        {
            DateTime dt1;
            DateTime.TryParse(DateTime.Now.ToString(), out dt1);
            Console.WriteLine(dt1 + " ");

            
            DateTime.TryParse(DateTime.Now.ToString(), out DateTime dt2);
            Console.WriteLine(dt2 + " ");

            DateTime.TryParse(DateTime.Now.ToString(), out var dt3);//it has function scope
            Console.WriteLine(dt3 + " ");

            int.TryParse("asdas", out var iv);//default value of int
            Console.WriteLine(iv);
        }
    }
}
