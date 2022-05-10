using System;
using System.Collections.Generic;

namespace ACAndL
{

    class Program
    {

        static void Main(string[] args)
        {
            // variables
            bool userChoiceBool;
            string userChoiceString;


            // create list of hourly employees
            List<Hourly> hourlyEmployeeList = new List<Hourly>();
            // create list of salaried employees
            List<Salary> salariedEmployeeList = new List<Salary>();

            // add some hourly employees to test the list
            hourlyEmployeeList.Add(new Hourly ("Emma", "Block", "H", 20.32));
            hourlyEmployeeList.Add(new Hourly ("Macy", "Craig", "H", 15.76));

            // add some salaried employees to test the list
            salariedEmployeeList.Add(new Salary ("Maggie", "Freemyer-Ackerman", "S", 65000));
            salariedEmployeeList.Add(new Salary ("Rand", "Ackerman", "S", 65000));
            
            
            // repeat main loop
            do
            {

                // get menu choice from user
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

                    // get valid menu option from user
                    userChoiceString = Console.ReadLine();
                    userChoiceBool = (userChoiceString == "L" || userChoiceString == "l" ||
                                      userChoiceString == "S" || userChoiceString == "s" ||
                                      userChoiceString == "C" || userChoiceString == "c" ||
                                      userChoiceString == "R" || userChoiceString == "r" ||
                                      userChoiceString == "U" || userChoiceString == "u" ||
                                      userChoiceString == "D" || userChoiceString == "d" ||
                                      userChoiceString == "Q" || userChoiceString == "q");

                    if (!userChoiceBool)
                    {
                        Console.WriteLine("Please enter a valid option from the list.");
                    }
                    
                } while (!userChoiceBool);



                //TO DO: L -- Load the single text file into the program. 
                if (userChoiceString=="L" || userChoiceString=="l")
                {
                    int index = 0; 
                    using (StreamReader sr = File.OpenText("Employees.txt"))
                    {

                        string fName = "";
                        while ((fName = sr.ReadLine()) != null)
                        {
                            


                        }
                    }

                }


                //TO DO: S -- Store the current employee information in the text file (no blank lines in data file)
                //TO DO: C -- Add a an employee (make sure user provides both, also handle "file full" case)
                if (userChoiceString=="C" || userChoiceString=="c")
                {
                    Console.WriteLine("Please enter 'H' to add a new Hourly employee, or 'S' to enter a Salaried employee.");
                    string addHOrS = Console.ReadLine();
                    if (addHOrS == "H" || addHOrS == "h")
                    {
                        // get hourly employee information from user input
                        int index = 0;
                        if (index < hourlyEmployeeList.Count)
                        {
                            Console.WriteLine("Please enter the new employee's first name.");
                            string fName = Console.ReadLine();
                            Console.WriteLine("Please enter the new employee's last name.");
                            string lName = Console.ReadLine();
                            string emplType = "H";
                            Console.WriteLine("What is the employee's hourly rate?");
                            string hRate = Console.ReadLine();

                            // add the new hourly employee to the hourly employees list.
                            hourlyEmployeeList.Add(new Hourly (fName, lName, emplType, Convert.ToDouble(hRate)));
                        }
                    }

                    else if (addHOrS == "S" || addHOrS == "s")
                    {
                        // get hourly employee information from user input
                        int index = 0;
                        if (index < salariedEmployeeList.Count)
                        {
                            Console.WriteLine("Please enter the new employee's first name.");
                            string fName = Console.ReadLine();
                            Console.WriteLine("Please enter the new employee's last name.");
                            string lName = Console.ReadLine();
                            string emplType = "S";
                            Console.WriteLine("What is the employee's annual salary?");
                            string salary = Console.ReadLine();

                            // add the new hourly employee to the hourly employees list.
                            salariedEmployeeList.Add(new Salary (fName, lName, emplType, Convert.ToDouble(salary)));
                        }
                    }

                    else 
                    {
                        Console.WriteLine("Please enter C to try again. Then enter either the letter 'H', or the letter 'S'.");
                    }
                }



                //TO DO: R -- Print a list of all the employees including their calculated bonus
                // print the hourly employee list
                if (userChoiceString=="R" || userChoiceString=="r")
                {
                    Console.WriteLine("This is a list of all employees. (Hourly employees are listed first.");
                    // find out if possible/easy to combine and then sort the values from both lists.
                    foreach (Hourly anEmployee in hourlyEmployeeList)
                    {
                        Console.WriteLine(anEmployee);
                    }

                    // print the salaried employee list
                    foreach (Salary anEmployee in salariedEmployeeList)
                    {
                        Console.WriteLine(anEmployee);
                    }

                    // print count of employee lists
                    int employeeCount = hourlyEmployeeList.Count + salariedEmployeeList.Count;
                }


                //to do: U -- Update information for an employee
                //to do: D -- Delete an employee
                //TO DO: Q -- Quit the program


                





            } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));

        }
    }
}