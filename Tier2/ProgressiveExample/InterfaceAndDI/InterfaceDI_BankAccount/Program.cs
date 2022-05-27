﻿using System;

namespace InterfaceDI_BankAccount
{
    public interface IMortgageAccount
    {
        void PrintAccountData();
    }
    public interface ISavingAccount
    {
        void PrintAccountData();
    }

    public interface ICheckingAccount
    {
        void PrintAccountData();
        void DeductFee(double theFee);
    }

    public class AccountInfo
    {
        int id;
        double balance;
        string customerName;

        public AccountInfo(int newID, double newBalance, string newCustomerName)
        {
            id = newID;
            balance = newBalance;
            customerName = newCustomerName;
        }
        
        public int ID // property
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance // property
        {
            get { return balance; }
            set { balance = value; }
        }

        public string CustomerName // property
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public override string ToString()
        {
            return "ID: " + ID.ToString() + "  Balance: " + Balance.ToString() + "  Customer Name: " + CustomerName;
        }
    }

    public interface IAccountInfo
    {
        // *** is this empty because of Dependency Injection?
    }

    public class Account : ISavingAccount, ICheckingAccount, IMortgageAccount, IAccountInfo
    {
        private AccountInfo theAccount;

        public Account(int newID, double newBalance, string newCustomerName)
        {
            theAccount = new AccountInfo(newID, newBalance, newCustomerName);
        }

        void IMortgageAccount.PrintAccountData()
        {
            Console.WriteLine("Mortgage account balance: " + theAccount.Balance);
        }

        void ISavingAccount.PrintAccountData()
        {
            Console.WriteLine("Saving account balance: " + theAccount.Balance);
        }

        void ICheckingAccount.PrintAccountData()
        {
            Console.WriteLine("Checking account balance: " + theAccount.Balance);
        }

        void ICheckingAccount.DeductFee(double theFee)
        {
            theAccount.Balance -= theFee;
        }

        public void PrintAccountData() // *** seek to understand this part
        {
            Console.WriteLine("Basic account balance: " + theAccount.Balance);
        }

        public override string ToString()
        {
            return theAccount.ToString();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            IMortgageAccount mortgageAccount = new Account(1, 150000, "Maggie");
            ISavingAccount savingAccount = new Account(2, 234.56, "Rand");
            ICheckingAccount checkingAccount = new Account(3, 456.78, "Merida");
            Account myAccount = new Account(4, 1.23, "Lloyd");
            mortgageAccount.PrintAccountData();
            savingAccount.PrintAccountData();
            checkingAccount.PrintAccountData();
            checkingAccount.DeductFee(5.25);
            myAccount.PrintAccountData();
            Console.WriteLine("Mortgage: " + mortgageAccount + "\nSavings: " + savingAccount + "\nChecking: " + checkingAccount + "\nMy account: " + myAccount);
            Console.ReadLine();
        }
    }
}