using System;

namespace ccpw3
{

    class Hourly : Employees // derived class (child)
    {
        public string emplType;
        public float hRate;


        // default constructor for when no values are being passed
        public Hourly ()
        {
            hRate = 0.00F;

        }

        // constructor for when values are passed
        public Hourly (float newHRate) 
        {
            hRate = newHRate;

        }

        // get, set methods
        public float GetHRate()
        {
            return hRate;
        }
        
        public void SetHRate (float newHRate)
        {
            hRate = newHRate;
        }

        // ToString
        public override string ToString()
        {
            return "Hourly Rate: $" + hRate;
        }

    }
}