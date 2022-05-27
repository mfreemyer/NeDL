using System;

namespace ccpw4
{

    class CD : Account, IGetAnnualInt
    // *** the CD has an annual interest rate and a penalty for early withdrawal

    {
        // properties
        double cDIntRate
            { get; set; }
        
        /* double eWPenalty 
            { get; set; } */


        //constructors
        public CD() : base()
        {
            cDIntRate = 0.0;
        }
        public CD(int newAcctID, double newAcctBal, string newAcctType, double newAnnualCDIntRate) : base (newAcctID, newAcctBal, newAcctType)
        {
            cDIntRate = newAnnualCDIntRate;

        }   


        // Withdrawal method
        // *** A CD withdrawal is allowed but the early withdrawal penalty is applied so the
               // balance needs to be greater than the withdrawal amount and the penalty combined.
        public override double Withdrawal()
        {
            double eWPenalty = (acctBal / 365 * cDIntRate) * 7;
            Console.WriteLine("The early withdrawal penalty for this account is " + String.Format("${0:n}",(eWPenalty)) + ".");
            Console.Write("The maximum allowable withdrawal amount is " + String.Format("${0:n}",((acctBal - eWPenalty))) + ". ");
            Console.Write("Please enter the withdrawal amount: ");
            double withdrawalAmt = Convert.ToDouble(Console.ReadLine());
            if (withdrawalAmt > 0)
            {
                if (acctBal >= withdrawalAmt + eWPenalty)
                {
                    Console.WriteLine(); // for user friendliness in terminal
                    Console.Write("The funds have been withdrawn. New balance: ");
                    return acctBal = acctBal - withdrawalAmt;
                }
                else
                {
                    Console.Write("Oops! The withdrawal amount cannot be greater than the account balance and early withdrawal penalty combined."); 
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
        public double GetAnnualInt()
        {
            return acctBal * cDIntRate;

        }

        // to string
        public override string ToString()
        {
            return base.ToString() + "  |  Annual Int Amt (based on interest rate: " + cDIntRate + "): " + String.Format("${0:n}",(GetAnnualInt()));
        }

    }
}