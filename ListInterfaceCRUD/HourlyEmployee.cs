using System;

namespace ListInterfaceCRUD
{

    class HourlyEmployee : Employee, IRate, IGetBonus
    {
        public double hRate // property
            { get; set; }

        // default constructor
        public HourlyEmployee() 
        {
            hRate = 0.0;
        }

        // constructor for when values are passed
        public HourlyEmployee(string newFName, string newLName, string newEmplType, double newHRate) : base (newFName, newLName, newEmplType)
        {
            hRate = newHRate;
        }

        // interface method from IRate
        public void SetRate(double newRate)
        {
            hRate = newRate;
        }

        // interface method from IGetBonus
        public double GetBonus()
        {
            return hRate * 80;
        }

        public override string ToString()
        {
            return base.ToString() + "  |  Hourly Rate: " + hRate + "  |  Bonus: " + GetBonus();
        }

    }
}