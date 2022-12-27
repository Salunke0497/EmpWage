using System;

namespace EmployeeWageUC10
{
    class program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("total wage of company is" + empWageBuilder.getTotalEmpWage(1));
            Console.ReadLine();
        }
    }
}
           
