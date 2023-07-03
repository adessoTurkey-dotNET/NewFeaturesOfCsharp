using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InKeyword
{
    public record Color
    {
        public string Name;
        public bool Metallic;
    }
    public record Car
    {
        public Color Color { get; set; }
        public string Engine { get; set; }
    }
    public record RecordPerson(string Firstname, DateOnly BirthDate);

    public class ClassPerson
    {
        public ClassPerson(string firstname, DateOnly birthDate)
        {
            Firstname = firstname;
            BirthDate = birthDate;
        }
        public string Firstname { get; init; }
        public DateOnly BirthDate { get; init; }
    }
    static public class Records
    {

        static public void Test()
        {
            var record1 = new RecordPerson("Ferhat", new DateOnly(1993, 8, 12));
            var record2 = new RecordPerson("Ferhat", new DateOnly(1993, 8, 12));
            //record2.BirthDate = new DateOnly(1992, 8, 12);CTE!!
            var record3 = record2 with { BirthDate = new DateOnly(1992, 8, 12) };

            var (name, birth) = record3;

            var class1 = new ClassPerson("Ferhat", new DateOnly(1993, 8, 12));
            var class2 = new ClassPerson("Ferhat", new DateOnly(1993, 8, 12));


            Console.WriteLine(record1 == record2);
            Console.WriteLine(ReferenceEquals(record1, record2));

            Console.WriteLine(class1 == class2);

            Console.WriteLine(record3);
            Console.WriteLine(birth);

            Car car1 = new Car() { Color = new Color() { Metallic = false, Name = "Black" }, Engine = "V5"};
            Car car2 = car1 with { Engine = "V6" };//Clone!!! shallow copy

            car2.Color.Name = "White";

            Console.WriteLine(car1);
            Console.WriteLine(car2);


        }
    }
}
