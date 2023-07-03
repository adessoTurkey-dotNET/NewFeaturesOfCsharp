using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InKeyword
{
    class PhoneNumber 
    {
        public int Code { get; set; }
        public int Number { get; set; }
    }
    class PersonDto
    {
        public string Name { get; set; }
        public PhoneNumber Phone { get; set; }
    }




    static public class PatternMatching8
    {
        static void ValidatePerson(PersonDto person)
        {
            var error = person switch
            {
                { Phone: null } => $"{person.Name} Phone info null",
                { Phone: { Number: 0 } } => $"{person.Name} Number is 0",
                { Phone: { Code: var code } } when code < 0 => $"{person.Name} code has to be more than 0",
                { } => null
            };

            if (error !!= null) throw new ArgumentException(error);
        }
        static public void Test()
        {
            var person1 = new PersonDto() {Name = "Ferhat", Phone = new() { Code = 553, Number = 2991986 }  };
            var person2 = new PersonDto() { Name = "Random", Phone = new() { Code = -1, Number = 2991986 } };
            try
            {
                ValidatePerson(person1);
                ValidatePerson(person2);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
