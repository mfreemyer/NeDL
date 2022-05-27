using System;

namespace ccpw4
{

    interface IGetAnnualInt
    // *** the savings and CD will implement a calculate annual interest method from an interface that will simply
           // return the annual amount earned based on the current balance and interest rate.  
           // Don't add this amount to the balance, but do report it on the toString for a saving or CD account.
    {
        // interface method
        double GetAnnualInt();

    }
}