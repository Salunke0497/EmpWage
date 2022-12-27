using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmpWage");
            Console.WriteLine("------------------");
            EmpWageBuilderObject dmart = EmpWageBuilderObject("Dmart",20, 2, 10);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.toString());
            EmpWageBuilderObject relience = EmpWageBuilderObject("relience", 10, 4, 20);
            relience.computeEmpWage();
            Console.WriteLine(relience.toString());
            Console.ReadLine();
        }
    }
}
