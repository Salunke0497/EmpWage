using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmpWage
    {
        public static void Empcheck()
        {
            Random random = new Random();
            int x = random.Next(0, 2);
            if (x == 0)
            {
                Console.WriteLine("employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");
            }
        }
    }
}
