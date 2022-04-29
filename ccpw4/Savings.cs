using System;

namespace ccpw4
{

    class Savings : Account/* , IGetAnnualInt */
    // *** the savings account has an annual interest rate
    {
        // properties
        double sIntRate
            { get; set; }


        //constructors

        public Savings() : base()
        {
            sIntRate = 0.0;
        }
        public Savings(int newAcctID, double newAcctBal, string newAcctType, double newSIntRate) : base (newAcctID, newAcctBal, newAcctType)
        {
            sIntRate = newSIntRate;
        }        


        // Withdrawal method
        // *** A savings account withdrawal is allowed as long as the account balance is greater than the withdrawal amount.
        public override double Withdrawal()
        {
            Console.WriteLine("How much do you want to withdraw from the savings account?");
            double withdrawalAmt = Convert.ToDouble(Console.ReadLine());
            if (withdrawalAmt > 0)
            {
                if (acctBal >= withdrawalAmt)
                {
                    Console.WriteLine(); // for user friendliness in terminal
                    Console.Write("The funds have been withdrawn. New balance: ");
                    return acctBal = acctBal - withdrawalAmt;
                }
                else
                {
                    Console.Write("Oops! The withdrawal amount cannot be greater than the account balance."); 
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


        // GetAnnualInt method


        // to string
        public override string ToString()
        {
            return base.ToString() + "  |  Annual Interest Rate: " + sIntRate;
        }


    }
}