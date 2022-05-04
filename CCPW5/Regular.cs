using System;

namespace CCPW5
// *** the regular membership has a flat percent for cash-back rewards on all purchases
{

    class Regular : Membership/* , ISpecialOffer */
    {
        // define properties
        public double rCBP // Regular Cash-Back Percentage
            { get; set; }

        // default constructor
        public Regular() : base()
        {
            rCBP = 0.02;
        }

        // constructor for when values are passed 
        public Regular(int newMemberID, string newEmail, char newMemberType, double newAnnualCost, double newCurrentPFM, double newRCBP) : base (newMemberID, newEmail, newMemberType, newAnnualCost, newCurrentPFM)
        {
            rCBP = newRCBP;
        }

        // methods
        public override double ApplyCBR() // print to console, then zero out the balance. 
        {
            Console.WriteLine("Cash-back reward request for membership " + memberID + " in the amount of " + String.Format("${0:n}",((currentPFM * rCBP))) + " has been made. " );
            Console.Write("The Purchases For Month (PFM) balance has been updated from " + String.Format("${0:n}",(currentPFM)));
            currentPFM = 0.0;
            Console.WriteLine(" to " + String.Format("${0:n}",(currentPFM)) + ".");
            return currentPFM;
        }

        


        // to string
        public override string ToString()
        {
            return base.ToString() + "  | Cash Back Reward Percentage: " + rCBP;
        }

    }
}