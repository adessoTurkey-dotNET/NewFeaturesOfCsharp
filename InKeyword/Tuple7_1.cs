using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    static public class Tuple7_1
    {
       
        static public void Test()
        {

            var ferhat = (name: "Ferhat", age: 235);
            Console.WriteLine(ferhat.age);

            var res = ferhat;
            //Console.WriteLine(res.Item1); //In c# 7 its the only way we can use
            Console.WriteLine(res.name);

            var days = new string[] { "Monday", "Tuesday", "Wednesday" };
            var val = days.Select(m => (day: m.ToString(), m.Length)).ToList();
            Console.WriteLine(string.Join(",", val.Select(x=>x.Length)));

            var val2 = val[1];
            var val3 = (val2.Length, val2.day) = (8, "Thursday");
            Console.WriteLine(val3);

        }
    }
}
