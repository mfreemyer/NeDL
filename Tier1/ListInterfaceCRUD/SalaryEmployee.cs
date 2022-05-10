using System;

namespace ListInterfaceCRUD
{

    class SalaryEmployee : Employee, IGetBonus
    {
        public double salary // property
            { get; set; }

        // default constructor
        public SalaryEmployee() 
        {
            salary = 0.0;
        }

        // constructor for when values are passed
        public SalaryEmployee(string newFName, string newLName, string newEmplType, double newSalary) : base (newFName, newLName, newEmplType)
        {
            salary = newSalary;
        }

        // interface method from IRate
        public override void SetRate(double newSalary)
        {
            salary = newSalary;
        }

        //interface method from IGetBonus
        public double GetBonus()
        {
            return salary * .1;
        }

        public override string ToString()
        {
            return base.ToString() + "  |  Annual Salary: " + salary + "  |  Bonus: " + GetBonus();
        }


    }
}