using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    static public class DeconstructKeywordFucn
    {
        public class Point
        {
            public int x,y;

            public void Deconstruct(out int _x, out int _y, out int _z)
            {
                _x = x;
                _y = y;
                _z = 10;
            }
        }

        static public void Test()
        {
            Point p = new Point();
            p.y = 10;
            p.x = 1;
            //...

            var (var1, var2, _) = p;

            Console.WriteLine(var1);

            var (var3, _, var4) = p;

            Console.WriteLine(var4);



        }
    }
}
