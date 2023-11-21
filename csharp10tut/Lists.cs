using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp10tut
{
    public class Lists
    {

        static void Main()
        {
            Technician T1 = new Technician
            {
                Id = 100,
                FullName = "Kwadwo Asare",
                Salary = 211.2,
            };


            Technician T2 = new Technician
            {
                Id = 101,
                FullName = "Kwame Darkwa",
                Salary = 451.2,
            };

            List<Technician> technicians = new List<Technician>(2);
            technicians.Add(T1);
            technicians.Add(T2);

            Console.WriteLine(technicians.IndexOf(T2));
            foreach (Technician technician in technicians)
            {
                Console.WriteLine("FullName : {0}", technician.
                    FullName);
            }

        }

    }


    class Technician
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public double Salary { get; set; }
    }
}
