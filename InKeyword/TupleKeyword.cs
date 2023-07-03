using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    static public class TupleKeywordFunc
    {
        static Tuple<double, double> SumAndProduct(double a, double b)
        {
            return Tuple.Create(a + b, a * b);
        }
        static (double sum, double product) NewSumAndProduct(double a, double b)
        {
            return (a + b, a * b);
        }
        static public void Test()
        {
            var v = SumAndProduct(3, 4);
            Console.WriteLine($"item1 = {v.Item1} item2 ={v.Item2}");
            var k = NewSumAndProduct(3, 4);
            Console.WriteLine($"item1 = {k.sum} item2 ={k.product}");
            Console.WriteLine(k.GetType().Name );
            Console.WriteLine(v.GetType().Name);

            (double s, double p) = NewSumAndProduct(3, 4);
            var (s2, p2) = NewSumAndProduct(3, 4);

            double s3,p3;
            (s3, p3) = NewSumAndProduct(3, 4);

            var ferhat = (name: "Ferhat", age: 235);
            Console.WriteLine(ferhat.age);

            var snp = new Func<double, double, (double sum, double pr)>((a,b)=>(a+b, a*b));

            var res = snp(1,5);
            Console.WriteLine(res.sum);
        }
    }
}
