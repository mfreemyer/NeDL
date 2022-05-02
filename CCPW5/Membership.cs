using System;

namespace CCPW5
{

    abstract class Membership
    {
        // define properties
        public int memberID
        { get; set; }
        public string email
        { get; set; }
        public char memberType
        { get; set; }
        public double annualCost
        { get; set; }
        public double currentPFM // current amount of Purchases For the Month
        { get; set; }

        // default constructor
        public Membership()
        {
            memberID = 0;
            email = "";
            memberType = '?';
            annualCost = 0.0;
            currentPFM = 0.0;
        }

        // constructor for when values are passed
        public Membership(int newMemberID, string newEmail, char newMemberType, double newAnnualCost, double newCurrentPFM)
        {
            memberID = newMemberID;
            email = newEmail;
            memberType = newMemberType;
            annualCost = newAnnualCost;
            currentPFM = newCurrentPFM;
        }


        // methods
        /* public double Purchase();
        {
            
        } */


        /* public double Return(); */
        // *** Return - A return of an item will include the membership id and the amount of the purchase returned 
                /// (which must be > 0).  All four accounts handle a return in the same way. If the membership ID 
                // exists, the current amount of purchases is decreased by the purchase amount.


        /* public abstract double ApplyCBR(); */ // apply cash-back rewards


        // to string
        public override string ToString()
        {
            return "Member ID: " + memberID + "  | Email: " + email + "  | Member Type: " + memberType + "  | Current Purchases for Month: " + currentPFM;
        }

    }
}