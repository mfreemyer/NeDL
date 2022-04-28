using System;

namespace ccpw4
{

    class CD : Account/* , IGetAnnualInt */
    // *** the CD has an annual interest rate and a penalty for early withdrawal
    // *** A CD withdrawal is allowed but the early withdrawal penalty is applied so the
           // balance needs to be greater than the withdrawal amount and the penalty combined.
    {
        // properties
        double annualCDIntRate
            { get; set; }
        
        double earlyWPenalty
            { get; set; }


        //constructors


        // Withdrawal method


        // GetAnnualInt method


        // to string


    }
}