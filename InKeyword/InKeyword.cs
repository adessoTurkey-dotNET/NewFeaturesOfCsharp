using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public class Myclass1
    {
        int x, y, z;
        public Myclass1()
        {
            this.x = 1;
            this.y = 2;
            this.z = 3;
        }
        public Myclass1(int _x, int _y, int _z)
        {
            this.x = _x;
            this.y = _y;
            this.z = _z;
        }

        public void WriteMyClass()
        {
            Console.WriteLine("z is: " + z + " y is: " + y + " x is: " + x);
        }


    }

    public class MyClass2
    {
        string name, lastname;
        public int point { get; set; }
        public int totalScore { get; set; }

        public MyClass2(string _name, string _lastname)
        {
            name = _name;
            lastname = _lastname;
            point = 0;
            totalScore = 0;
        }
        override public string ToString()
        {
            return name + " " + lastname + $" has {point} point and total score is {totalScore}";
        }
    }
    static public class InKeywordFunc
    {
        static public void Swap(ref Myclass1 first, ref Myclass1 second)
        {
            var temp = first;
            first = second;
            second = temp;
        }
        static public void Swap(Myclass1 first, Myclass1 second)
        {
            var temp = first;
            first = second;
            second = temp;
        }

        //static void CopyMyclassAndDoSomething(MyClass2 val)
        //{
        //    var tempVal = val;

        //    //

        //    tempVal.totalScore = 260;
        //    Console.WriteLine(tempVal.ToString());

        //}

        static void CopyMyclassAndDoSomething(in MyClass2 val)
        {
            var tempVal = val;

            //

            tempVal.totalScore = 280;
            Console.WriteLine(tempVal.ToString());

        }

        static void UpdateMyClass(MyClass2 val)
        {
            val.point = 124;
        }

        //static public void Swap(in Myclass1 first, int Myclass1 second)
        //{
        //    var temp = first;
        //    first = second;
        //    second = temp;
        //}
        //READONLY Compile Error!!

        static public void Test()
        {
            var c1 = new Myclass1();
            var c2 = new Myclass1(8, 6, 4);

            Swap(c1, c2);
            c1.WriteMyClass();

            Swap(ref c1, ref c2);
            c1.WriteMyClass();

            var c3 = new MyClass2("Ferhat", "Tümer");
            //
            c3.point = 15;
            //
            c3.totalScore = 250;

            CopyMyclassAndDoSomething(c3);//call by value(copy reference)

            CopyMyclassAndDoSomething(in c3);//call by reference readonly

            //https://stackoverflow.com/questions/8708632/passing-objects-by-reference-or-value-in-c-sharp
            UpdateMyClass(c3);

            Console.WriteLine(c3.ToString());
        }
    }

}
