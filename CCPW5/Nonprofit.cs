using System;

namespace CCPW5
// *** the non-profit membership has a cash-back percentage and also a field to indicate if it is a 
        // military or educational organization and if so doubles the cash-back percentage
{

    class Nonprofit : Membership
    {
        // define properties
        public double nCBP // Non-profit Cash-Back Percentage
            { get; set; }
        public char milOrEd // Y for yes, N for no 
            { get; set; }

        // default constructor
        public Nonprofit() : base()
        {
            nCBP = 0.03;
            milOrEd = '?';
        }

        // constructor for when values are passed 
        public Nonprofit(int newMemberID, string newEmail, char newMemberType, double newAnnualCost, double newCurrentPFM, double newNCBP, char newMilOrEd) : base (newMemberID, newEmail, newMemberType, newAnnualCost, newCurrentPFM)
        {
            nCBP = newNCBP;
            milOrEd = newMilOrEd;
        }

        // implementation of methods
        /* public override double ApplyCBR()
        {

        } */

        // to string
        public override string ToString()
        {
            return base.ToString() + "  | Cash Back Reward Percentage: " + nCBP + "  | Military or School: " + milOrEd;
        }


    }
}