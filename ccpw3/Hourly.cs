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




        /* public override string ToString()
        {
            return base.ToString() + "  Hourly Rate: " + String.Format("${0:n}",hRate);
        } */


        //bonus attempt
        public override string ToString()
        {
            return base.ToString() + "  Hourly Rate: " + String.Format("${0:n}",hRate)
            + "   Bonus: " + String.Format("${0:n}",(hRate * 80));
        }



        // bonus get, set 
        public float GetBonus()
        {
            return bonus;
        }

        // polymorphism attempt
        public override void SetBonus (float newBonus)
        {
            bonus = newBonus;
        }


        /* // create bonus object
        Hourly objBonus = new Hourly();
        // set bonus value
        objBonus.SetBonus(objHRate.GetHRate() * 80); */


    }
}