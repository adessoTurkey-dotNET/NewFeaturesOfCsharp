using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public static class Indexes
    {
        public static void Test()
        {
            Index i0 = 2;
            Index i1 = new Index(0, false);
            var i2 = ^0;//(Index(0, true))

            var items = new[] { 1, 2, 3, 4, 9, 6, 7 };
            Console.WriteLine(items[4]);

            items[^3] = 5;

            Console.WriteLine(items[4]);

            var items2 = items[0..^4];
            Console.WriteLine(items2.Length);

        }
    }
}
