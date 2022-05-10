using System;

namespace ACAndL
{

    class Hourly : Employees
    {
        public double hRate  // property
        { get; set; }

        public Hourly() : base()  // default constructor
        {
            hRate = 0.0;
        }

        public Hourly(string newFName, string newLName, string newEmplType, double newHRate) : base (newFName, newLName, newEmplType)
        {
            hRate = newHRate;
        }

        public override double GetBonus()
        {
            return hRate * 80;
        }

        public override string ToString()
        {
            return base.ToString() + "  |  Hourly Rate: " + hRate + "  Bonus: " + GetBonus();
        }

    }
}