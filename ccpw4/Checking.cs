using System;

namespace ccpw4
{

    class Checking : Account
    // *** the checking account has an annual fee
    // *** A checking account withdrawal is allowed but only up to 50% of the account balance.
    {
        // properties
        double annualChFee
            { get; set; }


        //constructors
        public Checking() : base()
        {
            annualChFee = 0.0;
        }
        public Checking(int newAcctID, double newAcctBal, string newAcctType, double newAnnualChFee) : base (newAcctID, newAcctBal, newAcctType)
        {
            annualChFee = newAnnualChFee;
        }   


        // Withdrawal method


        // to string
        public override string ToString()
        {
            return base.ToString() + "  |  Annual Fee: " + annualChFee;
        }

    }
}