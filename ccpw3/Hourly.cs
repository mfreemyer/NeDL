using System;

namespace ccpw3
{

    class Hourly : Employees // derived class (child)
    {
        public float hRate;
        //public float bonus = ;
        


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

        // bonus get, set 
        public float GetBonus()
        {
            return bonus;
        }

        /* // polymorphism attempt
        public override void SetBonus (float newBonus)
        {
            bonus = newBonus;
        }


        // create bonus object
        Hourly objBonus = new Hourly();
        // set bonus value
        objBonus.SetBonus(objHRate.GetHRate() * 80); */


    }
}