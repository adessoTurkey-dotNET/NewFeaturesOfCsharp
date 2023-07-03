using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public static class DefaultInterfaceMembers
    {
        public interface MyInterface
        {
            public void Func1();
            public void Func2()
            {
                Console.WriteLine("MyInterface!! Func2 Of MyInterface");
            }
            public void Func3()
            {
                Console.WriteLine($"MyInterface!! Func3 {Count} MyInterface");
            }

            public static void SetCount(int count)
            {
                Count = count;
            }
            private static int Count = 0;
        }

        public class MyClass : MyInterface
        {
            public void Func1()
            {
                Console.WriteLine("MyClass!! Func1 Of MyClass");
            }

        }

        public class MyClass2 : MyInterface
        {
            public MyClass2()
            {
                MyInterface.SetCount(2);
            }
            public void Func1()
            {
                Console.WriteLine("MyClass2!! Func1 Of MyClass2");
            }
            public void Func2()
            {
                Console.WriteLine("MyClass2!! Func2 Of MyClass2");
            }

        }


        public static void Test()
        {
            //MyClass2 myClass2 = new MyClass2();
            //myClass2.Func2();

            //MyClass myClass1 = new MyClass();
            //myClass1.Func2();//CTE

            MyInterface myClass1 = new MyClass();
            myClass1.Func1();
            MyInterface myClass3 = new MyClass2();
            myClass3.Func1();

            

        }
    }
}
