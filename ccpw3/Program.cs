using System;

namespace ccpw3
{

    class Program
    {

        static void Main(string[] args)
        {

            // declare and instantiate the array of employee objects
            Employees[] employeeArray = new Employees[25];

            // loop through each array element and instantiate an employee object for each
            for (int index = 0; index < employeeArray.Length; index++)
            {
                employeeArray[index] = new Employees();
            }

            employeeArray[0].SetFName("Maggie");
            employeeArray[0].SetLName("Freemyer-Ackerman");
            employeeArray[0].SetEmplType('S');
            //employeeArray[0].Set
            employeeArray[2].SetFName("Rand");
            employeeArray[2].SetLName("Ackerman");
            employeeArray[2].SetEmplType('S');
            employeeArray[4].SetFName("Dax");
            employeeArray[4].SetLName("Shepard");
            employeeArray[4].SetEmplType('H');


            // print non-null array values to test
            Console.WriteLine("Array Values:");
            for (int index = 0; index < employeeArray.Length; index++)
            {
                if (!(((employeeArray[index]).GetFName())==null))
                Console.WriteLine(employeeArray[index]);
            }





            // create objects
            Employees  objFName = new Employees();
            Employees objLName = new Employees();
            Hourly objHRate = new Hourly();
            Salary objSalary = new Salary();
            Hourly objBonus = new Hourly();

            // set values
            objFName.SetFName("Maggie");
            objLName.SetLName("Freemyer-Ackerman");
            objHRate.SetHRate(24.63F);
            objSalary.SetSalary(55000);
            objBonus.SetBonus(objHRate.GetHRate() * 80);

            Console.WriteLine();
            Console.WriteLine("Test Data:");
            Console.WriteLine("Employee Name: " + objFName.GetFName() + " " + objLName.GetLName());
            Console.WriteLine("Hourly Rate: $" + objHRate.GetHRate());
            Console.WriteLine("Salary: $" + objSalary.GetSalary());
            Console.WriteLine("Hourly Employee Bonus: $" + objBonus.GetBonus());

        }
    }
}