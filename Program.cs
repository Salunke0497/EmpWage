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
            //Console.WriteLine("Welcome to EmpWage");
            //Console.WriteLine("------------------");
            empwageclass.ComputeEmpWage("Dmart",20, 2, 10);
            empwageclass.ComputeEmpWage("relience", 10, 4, 20);
            Console.ReadLine();
        }
    }
}
