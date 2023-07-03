using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public static class DefaultKeyword
    {
        private static DateTime Func(List<int>? list = default)
        {
            return default;
        }
        public static void Test()
        {
            var res = 1;
            var val1 = res > 1 ? 1 : default;

            var list = new[] { default, 2, default };

            List<int> list2 = default;
            //Console.WriteLine(list2.Count); RTE
        }
    }
}
