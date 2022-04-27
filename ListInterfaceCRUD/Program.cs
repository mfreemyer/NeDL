using System;

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
            employeeList.Add(new Employee ("Macy", "Craig", "H"));

            // add some salaried employees to the list to test
            employeeList.Add(new SalaryEmployee ("Rand", "Ackerman", "S", 75000));
            employeeList.Add(new SalaryEmployee ("Doyle", "Freemyer", "S", 75000));            

            // print the list
            foreach (Employee anEmployee in employeeList)
            {
                Console.WriteLine(anEmployee);
            }

            // add an employee
            
        }
    }
}