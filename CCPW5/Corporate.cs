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
        /* public override double ApplyCBR()
        {

        } */

        

        // to string
        public override string ToString()
        {
            return base.ToString() + "  | Cash Back Reward Percentage: " + cCBP;
        }


    }
}