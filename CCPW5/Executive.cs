using System;

namespace CCPW5
// *** the executive membership has percentages for two tiers (one below $1000 and one above) of cash-back rewards on purchases
{

    class Executive : Membership/* , ISpecialOffer */
    {
        // define properties
        public double eCBP1 // Executive Cash-Back Percentage below $1000
            { get; set; }
        public double eCBP2 // Executive Cash-Back Percentage for $1000 and above
            { get; set; }

        // default constructor
        
        public Executive() : base()
        {
            eCBP1 = 0.03;
            eCBP2 = 0.04;
        }

        // constructor for when values are passed 
        public Executive(int newMemberID, string newEmail, char newMemberType, double newAnnualCost, double newCurrentPFM, double newECBP1, double newECBP2) : base (newMemberID, newEmail, newMemberType, newAnnualCost, newCurrentPFM)
        {
            eCBP1 = newECBP1;
            eCBP2 = newECBP2;
        }

        // methods
        public override double ApplyCBR() // print to console, then zero out the balance. 
        // Executive has percentages for two tiers (one below $1000 and one above) of cash-back rewards
        {
            if (currentPFM < 1000)
            {
                Console.WriteLine("Cash-back reward request for membership " + memberID + " in the amount of " + String.Format("${0:n}",((currentPFM * eCBP1))) + " has been made. " );
                Console.Write("The Purchases For Month (PFM) balance has been updated from " + String.Format("${0:n}",(currentPFM)));
                currentPFM = 0.0;
                Console.WriteLine(" to " + String.Format("${0:n}",(currentPFM)) + ".");
                return currentPFM;
            }

            else
            {
                Console.WriteLine("Cash-back reward request for membership " + memberID + " in the amount of " + String.Format("${0:n}",((currentPFM * eCBP2))) + " has been made. " );
                Console.Write("The Purchases For Month (PFM) balance has been updated from " + String.Format("${0:n}",(currentPFM)));
                currentPFM = 0.0;
                Console.WriteLine(" to " + String.Format("${0:n}",(currentPFM)) + ".");
                return currentPFM;
            }
        }


        

        // to string
        public override string ToString()
        {
            return base.ToString() + "  | Cash Back Reward Percentage: " + eCBP1 + " (" + eCBP2 + " above $1000)";
        }


    }
}