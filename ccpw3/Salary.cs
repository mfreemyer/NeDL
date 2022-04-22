using System;

namespace ccpw3
{

    class Salary : Employees  // derived class (child)
    {
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


        public override void SetBonus ()
        {
            Console.WriteLine(/* salary */ 65000 * .1);
        }



        // ToString
        public override string ToString()
        {
            return base.ToString() + "   Annual Salary: " + String.Format("${0:n}",salary)
            /* + "   Bonus: " + String.Format("${0:n}",(salary * .1)) */;
        }




    }
}