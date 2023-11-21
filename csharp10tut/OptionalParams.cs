using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp10tut
{
    internal class OptionalParams
    {

        static void Main()
        {
            Add(2, 3, 5, 6);
        }
        public static void Add(int FirstNumber, int SecondNumber, params object[] restofNumbers)
        {
            int result = FirstNumber + SecondNumber;

            if (restofNumbers != null)
            {
                foreach (int num in restofNumbers)
                {
                    result += num;
                }
            }

            Console.WriteLine("Sum : {0}", result);
        }
    }


}
