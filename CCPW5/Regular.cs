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

        // implementation of methods
        /* public override double ApplyCBR()
        {

        } */

        // to string
        public override string ToString()
        {
            return base.ToString() + "  | Cash Back Reward Percentage: " + rCBP;
        }

    }
}