using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InKeyword
{
    public class MyClass
    {
        public string Name { get; set; }
        public MyClass(string name) => Name = name ?? throw new ArgumentNullException(paramName: nameof(name));

        public int GetValue(int val)
        {
            return val > 0 ? val + 1 : throw new Exception();
        }
    }
    public static class ExceptionHandling
    {
        public static void Test()
        {
            int val = -1;
            try
            {
                var d = new MyClass("");
                val = d.GetValue(val);
            }
            catch(Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
            finally { Console.WriteLine(val); }

        }
    }
}
