using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp10tut
{
    class OptionalOverloading
    {

        static void main()
        {
            Add(2, 3, new int[] {2,1});
            Add(2, 1);
        }


        public static void Add(int FirstNumber,int SecondNumber)
        {
            Add(FirstNumber, SecondNumber, new int[] {});
        }
        public static void Add(int FirstNumber, int SecondNumber,  int[] restofNumbers)
        {

            int result = FirstNumber + SecondNumber;
            if (restofNumbers != null)
            {
                foreach (int num in restofNumbers)
                {
                    result += num;
                }
            }

            Console.WriteLine(result);
        }
    }
}
