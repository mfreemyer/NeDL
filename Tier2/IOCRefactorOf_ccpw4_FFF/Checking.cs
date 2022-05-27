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
            Console.WriteLine("How much do you want to withdraw from the account?");
            double withdrawalAmt = Convert.ToDouble(Console.ReadLine());
            if (withdrawalAmt > 0)
            {
                if ((acctBal/2) >= withdrawalAmt)
                {
                    Console.WriteLine(); // for user friendliness in terminal
                    Console.Write("The funds have been withdrawn. New balance: ");
                    return acctBal = acctBal - withdrawalAmt;
                }
                else
                {
                    Console.Write("Oops! The withdrawal amount cannot be greater than 50 percent of the account balance."); 
                    Console.Write("  Please try again. The balance remains unchanged: ");
                    return acctBal;
                }

            }
            else
            {
                Console.Write("Oops! Please start over and enter an amount greater than 0. The balance has not been updated: ");
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