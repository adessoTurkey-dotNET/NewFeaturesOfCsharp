using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public static class LocalFunction
    {

        static (double root1, double root2) CalDisc(double a, double b, double c)
        {
            //var func = new Func<double, double, double, double>((a, b, c) => { return b * b - 4 * a * c; });
            //var delta = Math.Sqrt(func(a, b, c));

            //double func()
            //{
            //    return b * b - 4 * a * c;
            //}

            double func() => b * b - 4 * a * c;

            var delta = Math.Sqrt(func());

            return (((-b - delta) / 2 * a),
                    ((-b + delta) / 2 * a)
                );
            
        }
        public static void Test()
        {
            var res = CalDisc(1, 3, 2);
            Console.WriteLine($"{res.root1} and {res.root2}");

        }
    }
}
