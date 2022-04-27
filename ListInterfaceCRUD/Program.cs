﻿using System;

namespace ListInterfaceCRUD
{

    class Program
    {

        static void Main(string[] args)
        {
            // create a list of employees
            List<Employee> employeeList = new List<Employee>();

            // add some employees to the list to test
            employeeList.Add(new Employee ("Maggie", "Freemyer-Ackerman", "S"));
            employeeList.Add(new Employee ("Emma", "Block", "H"));

            // add some salaried employees to the list to test
            employeeList.Add(new SalaryEmployee ("Rand", "Ackerman", "S", 75000));
            employeeList.Add(new SalaryEmployee ("Doyle", "Freemyer", "S", 75000));      

            // add some hourly employees to the list to test
            employeeList.Add(new HourlyEmployee ("Macy", "Craig", "H", 17.32));
            employeeList.Add(new HourlyEmployee ("Sam", "Craig", "H", 12.00));        

//*********************************************************************************************************
            // print the list
            foreach (Employee anEmployee in employeeList)
            {
                Console.WriteLine(anEmployee);
            }

//*********************************************************************************************************

            // add an employee (use switch to determine which object)
            Console.Write("Please enter the new employee's first name: ");
            string newFName = Console.ReadLine();
            Console.Write("Please enter the employee's last name: ");
            string newLName = Console.ReadLine();
            Console.Write("Please enter 'H' if the employee is paid hourly, or 'S' if they are salaried: ");
            string newEmplType = Console.ReadLine();
            switch (newEmplType)
            {
                case "S":
                case "s":
                    Console.Write("Please enter the annual salary: ");
                    double newEmplSalary = Convert.ToDouble(Console.ReadLine());
                    employeeList.Add(new SalaryEmployee(newFName, newLName, newEmplType, newEmplSalary));
                    Console.WriteLine("Salary employee added. Here is the new list.");
                break;
                case "H":
                case "h":
                    Console.Write("Please enter the employee's hourly rate: ");
                    double newEmplHourly = Convert.ToDouble(Console.ReadLine());
                    employeeList.Add(new HourlyEmployee(newFName, newLName, newEmplType, newEmplHourly));
                    Console.WriteLine("Hourly employee added. Here is the new list: ");
                break;
                default:
                    Console.WriteLine("The value entered must be either 'H' (for hourly) or 'S' (for salary).");
                break;
                //if there's time, experiment with giving another shot at entering a value if H or S is not entered.              
            }
            //print the list again (to show the employee was added).
            foreach (Employee anEmployee in employeeList)
            {
                Console.WriteLine(anEmployee);
            }
            
//*********************************************************************************************************
            
            // restructure classes to make this work. need to include SetRate in Employee Class.
            /* Console.Write("Please enter the first name of the employee whose pay you want to update: ");
            string findFName = Console.ReadLine();
            Console.Write("Please enter the first name of the employee whose pay you want to update: ");
            string findLName = Console.ReadLine();
            bool found = false;
            for (int index = 0; index < employeeList.Count; index++)
            {
                if((employeeList[index].fName == findFName) && (employeeList[index].lName == findLName))
                {
                    
                    Console.WriteLine("Employee found! " + employeeList[index].fName + employeeList[index].lName + "'s employee type is " + employeeList[index].emplType);
                    string updatePayType = employeeList[index].emplType;
                    switch (updatePayType)
                    {
                        case "S":
                        case "s":
                            Console.Write("What is the new pay amount?");
                            double newPayAmount = Convert.ToDouble(Console.ReadLine());
                            employeeList[index].SetRate(newPayAmount);

                    }
                    
                }
            


            } */



//*********************************************************************************************************


        }
    }
}