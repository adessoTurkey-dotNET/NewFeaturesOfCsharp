using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public  class Person
    {
        private int id;
        private static readonly Dictionary<int, string> names = new Dictionary<int, string>();
        public Person(int id, string name) => names.Add(id, name);
        ~Person() => names.Remove(id);

        public string Name
        {
            get => names [id];
            set => names[id] = value;
        } 
    }
    public static class ExpressionBodiedMembers
    {
        public static void Test()
        {
            var val = new Person(1, "Ferhat");
            val.Name = "Test";
            Console.WriteLine(val.Name);
        }
    }
}
