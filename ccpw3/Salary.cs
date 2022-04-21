using System;

namespace ccpw3
{

    class Salary : Employees  // derived class (child)
    {
        public string emplType;
        public int salary;


        // default constructor for when no values are being passed
        public Salary ()
        {
            salary = 0;

        }

        // constructor for when values are passed
        public Salary (int newSalary) 
        {
            salary = newSalary;

        }

        // get, set methods
        public int GetSalary()
        {
            return salary;
        }
        
        public void SetSalary (int newSalary)
        {
            salary = newSalary;
        }

        // ToString
        public override string ToString()
        {
            return "Annual Salary: $" + salary;
        }


    }
}