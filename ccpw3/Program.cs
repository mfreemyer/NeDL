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

            for (int index = 0; index < hourlyArray.Length; index++)
                {
                    hourlyArray[index] = new Hourly ();
                }


            Salary[] salaryArray = new Salary[25];

            for (int index = 0; index < salaryArray.Length; index++)
                {
                    salaryArray[index] = new Salary ();
                }


                    hourlyArray[0].SetFName("Merida");
                    hourlyArray[0].SetLName("Ackerman");
                    hourlyArray[0].SetEmplType('H');
                    hourlyArray[0].SetHRate(15.32F);
                    hourlyArray[2].SetFName("Lloyd");
                    hourlyArray[2].SetLName("Ackerman");
                    hourlyArray[2].SetEmplType('H');
                    hourlyArray[2].SetHRate(14.20F);
                    hourlyArray[4].SetFName("Macy");
                    hourlyArray[4].SetLName("Craig");
                    hourlyArray[4].SetEmplType('H');

                    salaryArray[0].SetFName("Maggie");
                    salaryArray[0].SetLName("Freemyer-Ackerman");
                    salaryArray[0].SetEmplType('S');
                    salaryArray[0].SetSalary(65000);
                    salaryArray[2].SetFName("Rand");
                    salaryArray[2].SetLName("Ackerman");
                    salaryArray[2].SetEmplType('S');
                    salaryArray[2].SetSalary(65000);
                    salaryArray[4].SetFName("Doyle");
                    salaryArray[4].SetLName("Freemyer");
                    salaryArray[4].SetEmplType('S');
                    salaryArray[4].SetSalary(200000);


            // repeat main looop
            do
            {

                //get a valid input
                do
                {
                    //Menu of options
                    Console.WriteLine("WHAT WOULD YOU LIKE TO DO?");
                    Console.WriteLine("L: Load the employee file");
                    Console.WriteLine("S: Save changes");
                    Console.WriteLine("C: Create a new employee record");
                    Console.WriteLine("R: Read/print a list of employee information");
                    Console.WriteLine("U: Update an employee's information");
                    Console.WriteLine("D: Delete an employee record");
                    Console.WriteLine("Q: Quit the program");

                    // get valid option from user
                                
                        userChoiceString = Console.ReadLine();
                        userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                                    userChoiceString == "S" || userChoiceString == "s" ||
                                    userChoiceString == "C" || userChoiceString == "c" ||
                                    userChoiceString == "R" || userChoiceString == "r" ||
                                    userChoiceString == "U" || userChoiceString == "u" ||
                                    userChoiceString == "D" || userChoiceString == "d" ||
                                    userChoiceString == "Q" || userChoiceString == "q");

                        if (!userChoice)
                        {
                            Console.WriteLine("Please enter a valid option from the list.");
                        }
                    
                } while (!userChoice);



            //TO DO: L -- Load the single text file into the program. 
            if (userChoiceString=="L" || userChoiceString=="l")
            {
                Console.WriteLine("Load area");
                /* int index = 0; 
                using (StreamReader sr = File.OpenText("Employees.txt"))
                {
                    
                } */
            }

            //TO DO: S -- Store the current employee information in the text file (no blank lines in data file)

            //TO DO: C -- Add a an employee (make sure user provides all info, also handle "file full" case)
            // i think need to add another if statement to find out if hourly or salaried before asking for the rest... 
            if (userChoiceString=="C" || userChoiceString=="c")
            {
                bool contains = false;
                for (int index = 0; index < hourlyArray.Length; index++)
                {
                    if ((hourlyArray[index] == null) && (contains == false))
                    {
                        contains = true;
                        //get new name from user (got lots of help from Mark on this. Study it.)
                        Hourly hourly = new Hourly(); // create object for hourly employees 
                        Console.WriteLine("Please enter the new employee's first name.");
                        string fName = Console.ReadLine();
                        hourly.SetFName(fName);
                        Console.WriteLine("Please enter the new employee's last name.");
                        string lName = Console.ReadLine();
                        hourly.SetLName(lName);

                        
                    }
                }

                if (contains == false)
                {
                    Console.WriteLine("The employee list is full.");
                }
            }




            //TO DO: R -- Print a list of all the employees including their calculated bonus, 
                          //{{call calculated bonus function. This will use polymorphism}}
            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                // loop through each hourlyArray element and instantiate an hourly employee object for each
                Console.WriteLine("List of employees:");
                
                    // print non-null hourlyArray values to test
                    for (int index = 0; index < hourlyArray.Length; index++)
                    {
                        if (!(((hourlyArray[index]).GetFName())==null))
                            Console.WriteLine(hourlyArray[index]);
                    }


                    // print non-null salaryArray values to test
                    for (int index = 0; index < hourlyArray.Length; index++)
                    {
                        if (!(((salaryArray[index]).GetFName())==null))
                            Console.WriteLine(salaryArray[index]);
                    }


            }




            //to do: U -- Update information for an employee

            //to do: D -- Delete an employee

            //TO DO: Q -- Quit the program
            } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
            {
                Console.WriteLine("Have a nice day!");
            } //ends 'repeat main loop'



        }
    }
}