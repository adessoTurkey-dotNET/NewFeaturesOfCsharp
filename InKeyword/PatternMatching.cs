using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    class Shape
    {

    }

    class Rectangle : Shape
    {
        public Rectangle(int _width, int _height)
        {
          Width = _width;
          Height = _height;
        }
        public int Width;
        public int Height;

    }

    class Circle : Shape
    {
        public Circle(int _radius)
        {
            radius = _radius;
        }
        public int radius;
    }
    static public class PatternMatchingFunc
    {
        static void DisplayShapeArea(Shape sh)
        {
            switch (sh)
            {
                case Circle c: Console.WriteLine(c.radius * c.radius * 3.14); break;
                case Rectangle sq when (sq.Height == sq.Width): Console.WriteLine($"square area : { sq.Width* sq.Width}"); break;
                case Rectangle rectangle: Console.WriteLine(rectangle.Height * rectangle.Width); break;
                default:
                    break;
            }

            if(sh is Rectangle) 
            {
                //do something
            }
            if(sh is Circle)
            {
                //do something
            }
        }
        static public void Test()
        {
            Rectangle rectangle1 = new Rectangle(2,6);
            Rectangle rectangle2 = new Rectangle(2, 2);
            Circle circle = new Circle(6);

            DisplayShapeArea(rectangle1);
            DisplayShapeArea(rectangle2);
            DisplayShapeArea(circle);



        }
    }
}
