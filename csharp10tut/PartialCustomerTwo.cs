using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp10tut
{
    public partial class PartialCustomer
    {

        public void GetFullName()
        {
            Console.WriteLine($"FirstName : {this._firstName}\nLastName:{this._lastName}");
        }
    }

    public class PartialCustomerTwo
    {
        static void main()
        {
            PartialCustomer P1 = new PartialCustomer();
            P1.GetFullName();
        }
    }
}
