using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public struct Point
    {
        public int x, y;

        private static Point origin = new Point();
        public static ref readonly Point Origin => ref origin;
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
            Console.WriteLine("Point(int _x, int _y)");
        }

        public Point(Point s)
        {
            x = s.x;
            y = s.y;
            Console.WriteLine("Copy Cons");
        }

    }

    static public class ReadOnlyRefFunc
    {
        static double MeasureDistance(in Point p1, in Point p2)
        {
            var dx = p1.x - p2.x;
            var dy = p1.y - p2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        static double MeasureDistance(ref Point p1, Point p2)
        {
            var dx = p1.x - p2.x;
            var dy = p1.y - p2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }


        static double MeasureDistance(Point p1, in Point p2)
        {
            var dx = p1.x - p2.x;
            var dy = p1.y - p2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        static double MeasureDistance(Point p1, Point p2)
        {
            var dx = p1.x - p2.x;
            var dy = p1.y - p2.y;
            p2.y = dx * dx + dy * dy;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        static public void Test()
        {
            var c1 = new Point(2, 4);
            var c2 = new Point(8, 6);

            MeasureDistance(c1, c2);

            MeasureDistance(c1, Point.Origin);

            Console.WriteLine(Point.Origin.y);

            Point den = Point.Origin;//copy by value

            den.x = 2;

            ref readonly Point den2 = ref Point.Origin;
            
            //ref var den3 = ref Point.Origin;CTE

        }
    }

}
