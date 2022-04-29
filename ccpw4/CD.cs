using System;

namespace ccpw4
{

    class CD : Account/* , IGetAnnualInt */
    // *** the CD has an annual interest rate and a penalty for early withdrawal

    {
        // properties
        double annualCDIntRate
            { get; set; }
        
        double earlyWPenalty // might not need this. maybe this will just be a calculation...
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

        // GetAnnualInt method


        // to string
        public override string ToString()
        {
            return base.ToString() + "  |  Annual CD Interest Rate: " + annualCDIntRate;
        }


    }
}