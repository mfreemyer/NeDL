using System;

namespace ccpw4
{

    abstract class Account
    {
        public int acctID
            { get; set; }

        public double acctBal
            { get; set; }

        public string acctType
            { get; set; }


        // default constructor
        public Account()
        {
            acctID = 0;
            acctBal = 0;
            acctType = "";
        }

        // constructor for when values are passed
        public Account(int newAcctID, double newAcctBal, string newAcctType)
        {
            acctID = newAcctID;
            acctBal = newAcctBal;
            acctType = newAcctType;
        }


        // deposit method
        /* *** Deposit - A deposit will include the account id and the amount of the deposit (which must be > 0). 
        All three accounts handle a deposit the same way. If the account exists, the balance is increased by the deposit amount. *** */
        public void Deposit(double depositAmt)
        {
            //depositAmt = Convert.ToDouble(Console.ReadLine());
            if (depositAmt > 0)
            {
                acctBal = acctBal + depositAmt;
                Console.Write("The deposit has been made. New balance: ");
            }
            else
            {
                Console.Write("Please enter an amount greater than 0. The balance has not been updated: ");
                
            }

        }

        // abstract withdrawal method
        /* public abstract double Withdrawal(); */


        // to string
        public override string ToString()
        {
            return "Account Id: " + acctID + "  |  Balance: " + acctBal + "  |  Account Type: " + acctType;
        }


    }
}