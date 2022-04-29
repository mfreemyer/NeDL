using System;

namespace ccpw4
{

    class Checking : Account
    // *** the checking account has an annual fee
    
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
        // *** A checking account withdrawal is allowed but only up to 50% of the account balance.
        public override double Withdrawal()
        {
            double withdrawalAmt = 0;
            if (withdrawalAmt > 0)
            {
                Console.WriteLine();  // for user friendliness in terminal
                Console.Write("The funds have been withdrawn. New balance: ");
                return acctBal = acctBal - withdrawalAmt;
            }
            else
            {
                Console.Write("Please enter an amount greater than 0. The balance has not been updated: ");
                return acctBal;
                
            }

        }

        // to string
        public override string ToString()
        {
            return base.ToString() + "  |  Annual Fee: " + annualChFee;
        }

    }
}