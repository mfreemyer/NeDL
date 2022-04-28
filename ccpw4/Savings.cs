using System;

namespace ccpw4
{

    class Savings : Account/* , IGetAnnualInt */
    // *** the savings account has an annual interest rate
    // *** A savings account withdrawal is allowed as long as the account balance is greater than the withdrawal amount.
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
        /* public override double Withdrawal();
        {
            
        } */


        // GetAnnualInt method


        // to string
        public override string ToString()
        {
            return base.ToString() + "  |  Interest Rate: " + sIntRate;
        }


    }
}