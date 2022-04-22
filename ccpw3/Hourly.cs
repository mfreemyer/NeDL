using System;

namespace ccpw3
{

    class Hourly : Employees // derived class (child)
    {
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




        public override string ToString()
        {
            return base.ToString() + "  Hourly Rate: " + String.Format("${0:n}",hRate)
            /* + "   Bonus: " + String.Format("${0:n}",(hRate * 80)) */;
        }




        // polymorphism attempt
        public override void SetBonus ()
        {
            Console.WriteLine(/* hRate */ 20 * 80);
        }



    }
}