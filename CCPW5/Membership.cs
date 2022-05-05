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


        // methods*************************************************************
        // Purchase method
        public void Purchase(double purchaseAmount)
        {
            currentPFM = currentPFM + purchaseAmount;
        }


        // Return method
        public void Return(double returnAmount)
        {
            currentPFM = currentPFM - returnAmount;
        }
        


        // ApplyCBR method
        public abstract double ApplyCBR(); // apply cash-back rewards abstract method


        





        // to string
        public override string ToString()
        {
            return "Member ID: " + memberID + "  | Email: " + email + "  | CPFM *: " + String.Format("${0:n}",(currentPFM)) + "  | Member Type: " + memberType + "  | Annual Cost: " + String.Format("${0:n}",(annualCost));
        }

    }
}