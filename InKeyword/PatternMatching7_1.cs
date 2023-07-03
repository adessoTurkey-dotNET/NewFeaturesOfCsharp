using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    class Vehicle {}
    class Automobile : Vehicle { }
    class Truck : Vehicle { }




    static public class PatternMatching7_1Func
    {
        static void StartEngine<T>(T vehicle)
            where T : Vehicle
        {
            switch (vehicle)//In C#7 its not compileable
            {
                case Automobile: Console.WriteLine("Automobile"); break;
                case Truck: Console.WriteLine("Truck"); break;
                default:
                    break;
            }

            if(vehicle is Automobile) 
            {
                //do something
            }
            if(vehicle is Truck)
            {
                //do something
            }
        }
        static public void Test()
        {
            StartEngine(new Automobile());
        }
    }
}
