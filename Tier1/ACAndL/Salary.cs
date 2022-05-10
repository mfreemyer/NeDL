using System;

namespace ACAndL
{

    class Salary : Employees
    {
        public double salary
        { get; set; }


        public Salary() : base()  // default constructor
        {
            salary = 0;
        }

        public Salary(string newFName, string newLName, string newEmplType, double newSalary) : base (newFName, newLName, newEmplType)
        {
            salary = newSalary;
        }

        public override double GetBonus()
        {
            return salary * .1;
        }


        public override string ToString()
        {
            return base.ToString() + "  |  Annual Salary: " + salary + "  Bonus: " + GetBonus();
        }

    }
}