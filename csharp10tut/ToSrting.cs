using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp10tut
{
    internal class ToSrting
    {
        static void Main()
        {

            Person person = new Person();
            person.FirstName = "Wassem";
            person.LastName = "Darkwa";

            Console.WriteLine(person.ToString());

        }
    }

    class Person
    {
        private string _firstname;
        private string _lastname;

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;set;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
