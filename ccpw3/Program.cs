using System;

namespace ccpw3
{

    class Program
    {

        static void Main(string[] args)
        {

            // declare and instantiate the array of hourly employee objects
            Hourly[] hourlyArray = new Hourly[25];

            // loop through each array element and instantiate an employee object for each
            for (int index = 0; index < hourlyArray.Length; index++)
            {
                hourlyArray[index] = new Hourly ();
            }

            hourlyArray[0].SetFName("Maggie");
            hourlyArray[0].SetLName("Freemyer-Ackerman");
            hourlyArray[0].SetEmplType('S');
            hourlyArray[0].SetHRate(20.32F);
            hourlyArray[2].SetFName("Rand");
            hourlyArray[2].SetLName("Ackerman");
            hourlyArray[2].SetEmplType('S');
            hourlyArray[4].SetFName("Dax");
            hourlyArray[4].SetLName("Shepard");
            hourlyArray[4].SetEmplType('H');


            // print non-null array values to test
            Console.WriteLine("Array Values:");
            for (int index = 0; index < hourlyArray.Length; index++)
            {
                if (!(((hourlyArray[index]).GetFName())==null))
                Console.WriteLine(hourlyArray[index]);
            }





            // create objects for Hourly
            Hourly  HFNameObj = new Hourly();
            Hourly HLNameObj = new Hourly();
            Hourly HRateObj = new Hourly();
            //Hourly objBonus = new Hourly();

            // create objects for Salary
            Salary  SFNameObj = new Salary();
            Salary SLNameObj = new Salary();
            Salary SSalaryObj = new Salary();


            // set values for Hourly
            HFNameObj.SetFName("Maggie");
            HLNameObj.SetLName("Freemyer-Ackerman");
            HRateObj.SetHRate(24.63F);
            //objBonus.SetBonus(objHRate.GetHRate() * 80);

            // set values for Salary
            SFNameObj.SetFName("Rand");
            SLNameObj.SetLName("Ackerman");
            SSalaryObj.SetSalary(65000);


            //Test Hourly data
            Console.WriteLine();
            Console.WriteLine("Test Data for Hourly Employees:");
            Console.WriteLine("Employee Name: " + HFNameObj.GetFName() + " " + HLNameObj.GetLName());
            Console.WriteLine("Hourly Rate: $" + HRateObj.GetHRate());
            //Console.WriteLine("Salary: $" + objSalary.GetSalary());
            //Console.WriteLine("Hourly Employee Bonus: $" + objBonus.GetBonus());

            //Test Salary data
            Console.WriteLine();
            Console.WriteLine("Test Data for Salaried Employees:");
            Console.WriteLine("Employee Name: " + SFNameObj.GetFName() + " " + SLNameObj.GetLName());
            Console.WriteLine("Hourly Rate: $" + SSalaryObj.GetSalary());



        }
    }
}