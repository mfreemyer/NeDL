using System;

namespace ccpw4
{

    class CD : Account/* , IGetAnnualInt */
    // *** the CD has an annual interest rate and a penalty for early withdrawal

    {
        // properties
        double annualCDIntRate
            { get; set; }
        
        double earlyWPenalty 
            { get; set; }


        //constructors
        public CD() : base()
        {
            annualCDIntRate = 0.0;
        }
        public CD(int newAcctID, double newAcctBal, string newAcctType, double newAnnualCDIntRate) : base (newAcctID, newAcctBal, newAcctType)
        {
            annualCDIntRate = newAnnualCDIntRate;
        }   


        // Withdrawal method
        // *** A CD withdrawal is allowed but the early withdrawal penalty is applied so the
               // balance needs to be greater than the withdrawal amount and the penalty combined.
        public override double Withdrawal()
        {
            Console.WriteLine("How much do you want to withdraw from the account?");
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
            return base.ToString() + "  |  Annual CD Interest Rate: " + annualCDIntRate;
            // i think annualCDIntRate should be a calculation instead of a hard-coded value. 
        }


    }
}