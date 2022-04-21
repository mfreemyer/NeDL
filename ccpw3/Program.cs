using System;

namespace ccpw3
{

    class Program
    {

        static void Main(string[] args)
        {
            // create objects
            Employees  objFName = new Employees();
            Employees objLName = new Employees();
            Hourly objHRate = new Hourly();
            Salary objSalary = new Salary();

            // set values
            objFName.SetFName("Maggie");
            objLName.SetLName("Freemyer-Ackerman");
            objHRate.SetHRate(24.63F);
            objSalary.SetSalary(55000);

            Console.WriteLine("Employee Name: " + objFName.GetFName() + " " + objLName.GetLName());
            Console.WriteLine("Hourly Rate: $" + objHRate.GetHRate());
            Console.WriteLine("Salary: $" + objSalary.GetSalary());

        }
    }
}