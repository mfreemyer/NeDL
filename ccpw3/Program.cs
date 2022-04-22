using System;

namespace ccpw3
{

    class Program
    {

        static void Main(string[] args)
        {

            // declare variables
            bool userChoice;
            string userChoiceString;
          
            // declare and instantiate the arrays of hourly employee objects and salary employee objects
            Hourly[] hourlyArray = new Hourly[25];
            Salary[] salaryArray = new Salary[25];






//*****************************
            // loop through each hourlyArray element and instantiate an hourly employee object for each
            for (int index = 0; index < hourlyArray.Length; index++)
            {
                hourlyArray[index] = new Hourly ();
            }

            hourlyArray[0].SetFName("Merida");
            hourlyArray[0].SetLName("Ackerman");
            hourlyArray[0].SetEmplType('H');
            hourlyArray[0].SetHRate(15.32F);
            hourlyArray[2].SetFName("Lloyd");
            hourlyArray[2].SetLName("Ackerman");
            hourlyArray[2].SetEmplType('H');
            hourlyArray[4].SetFName("Macy");
            hourlyArray[4].SetLName("Craig");
            hourlyArray[4].SetEmplType('H');

            // print non-null hourlyArray values to test
            Console.WriteLine();
            Console.WriteLine("Hourly Array Values:");
            for (int index = 0; index < hourlyArray.Length; index++)
            {
                if (!(((hourlyArray[index]).GetFName())==null))
                Console.WriteLine(hourlyArray[index]);
            }


//*****************************

            // loop through each salaryArray element and instantiate a salaried employee object for each
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

            // print non-null salaryArray values to test
            Console.WriteLine();
            Console.WriteLine("Salary Array Values:");
            for (int index = 0; index < hourlyArray.Length; index++)
            {
                if (!(((salaryArray[index]).GetFName())==null))
                Console.WriteLine(salaryArray[index]);
            }


//*****************************

            // polymorphism -- don't yet know how to tie it in with the object for each class.
            Employees EBonusObj = new Employees();
            Hourly HBonusObj = new Hourly();
            Salary SBonusOjb = new Salary();

            EBonusObj.SetBonus();
            HBonusObj.SetBonus();
            SBonusOjb.SetBonus();


            //TO DO: O -- Load the single text file into the program. 
            //TO DO: S -- Store the current employee information in the text file (no blank lines in data file)
            //TO DO: C -- Add a an employee (make sure user provides both, also handle "file full" case)
            //TO DO: R -- Print a list of all the employees including their calculated bonus, 
                          //{{call calculated bonus function. This will use polymorphism}}
            //to do: U -- Update information for an employee,
            //to do: D -- Delete an employee
            //TO DO: Q -- Quit the program





        }
    }
}