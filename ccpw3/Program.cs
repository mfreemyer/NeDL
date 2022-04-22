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

            hourlyArray[0].SetFName("Merida");
            hourlyArray[0].SetLName("Ackerman");
            hourlyArray[0].SetEmplType('H');
            hourlyArray[0].SetHRate(15.00F);
            hourlyArray[2].SetFName("Lloyd");
            hourlyArray[2].SetLName("Ackerman");
            hourlyArray[2].SetEmplType('H');
            hourlyArray[4].SetFName("Macy");
            hourlyArray[4].SetLName("Craig");
            hourlyArray[4].SetEmplType('H');


            // print non-null array values to test
            Console.WriteLine();
            Console.WriteLine("Hourly Array Values:");
            for (int index = 0; index < hourlyArray.Length; index++)
            {
                if (!(((hourlyArray[index]).GetFName())==null))
                Console.WriteLine(hourlyArray[index]);
            }

//*****************************
            // declare and instantiate the array of salary employee objects
            Salary[] salaryArray = new Salary[25];

            // loop through each array element and instantiate an employee object for each
            for (int index = 0; index < salaryArray.Length; index++)
            {
                salaryArray[index] = new Salary ();
            }

            salaryArray[0].SetFName("Maggie");
            salaryArray[0].SetLName("Freemyer-Ackerman");
            salaryArray[0].SetEmplType('H');
            salaryArray[0].SetSalary(65000);
            salaryArray[2].SetFName("Rand");
            salaryArray[2].SetLName("Ackerman");
            salaryArray[2].SetEmplType('H');
            salaryArray[2].SetSalary(65000);
            salaryArray[4].SetFName("Doyle");
            salaryArray[4].SetLName("Freemyer");
            salaryArray[4].SetEmplType('S');
            salaryArray[4].SetSalary(200000);


            // print non-null array values to test
            Console.WriteLine();
            Console.WriteLine("Salary Array Values:");
            for (int index = 0; index < hourlyArray.Length; index++)
            {
                if (!(((salaryArray[index]).GetFName())==null))
                Console.WriteLine(salaryArray[index]);
            }

//*****************************





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


            /* //Test Hourly data
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
            Console.WriteLine("Hourly Rate: $" + SSalaryObj.GetSalary()); */



        }
    }
}