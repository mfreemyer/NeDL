using System;

namespace ACAndL
{

    class Program
    {

        static void Main(string[] args)
        {
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

            // print the hourly employee list
            foreach (Hourly anEmployee in hourlyEmployeeList)
            {
                Console.WriteLine(anEmployee);
            }

            // print the salaried employee list
            foreach (Salary anEmployee in salariedEmployeeList)
            {
                Console.WriteLine(anEmployee);
            }

        }
    }
}