using System;

namespace CCPW5
// *** the corporate membership has a flat percent for cash-back rewards
{

    class Corporate : Membership
    {
        // define properties
        public double cCBP // Corporate Cash-Back Percentage
            { get; set; }

        // default constructor
        public Corporate() : base()
        {
            cCBP = 0.02;
        }

        // constructor for when values are passed 
        public Corporate(int newMemberID, string newEmail, char newMemberType, double newAnnualCost, double newCurrentPFM, double newCCBP) : base (newMemberID, newEmail, newMemberType, newAnnualCost, newCurrentPFM)
        {
            cCBP = newCCBP;
        }

        // methods
        public override double ApplyCBR() // print to console, then zero out the balance. 
        {
            Console.WriteLine("Cash-back reward request for membership " + memberID + " in the amount of " + String.Format("${0:n}",((currentPFM * cCBP))) + " has been made. " );
            Console.Write("The Purchases For Month (PFM) balance has been updated from " + String.Format("${0:n}",(currentPFM)));
            currentPFM = 0.0;
            Console.WriteLine(" to " + String.Format("${0:n}",(currentPFM)) + ".");
            return currentPFM;
        }

        

        // to string
        public override string ToString()
        {
            return base.ToString() + "  | Cash Back Reward Percentage: " + cCBP;
        }


    }
}