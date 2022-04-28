using System;

namespace ccpw4
{

    class Program
    {

        static void Main(string[] args)
        {
            // create lists
            List<Savings> savingsAcctList = new List<Savings>();
            List<Checking> checkingAcctList = new List<Checking>();
            List<CD> cDAcctList = new List<CD>();

            // hard code the data into the lists
            savingsAcctList.Add(new Savings (012345678, 7323.08, "S", .1));
            savingsAcctList.Add(new Savings (876543210, 10528.72, "S", .1));
            
            checkingAcctList.Add(new Checking (123456789, 3000.05, "Ch", 2));
            checkingAcctList.Add(new Checking (987654321, 800.17, "Ch", 2));

            // print the lists
            foreach (Savings aSavingsAcct in savingsAcctList)
            {
                Console.WriteLine(aSavingsAcct);
            }
            
            foreach (Checking aCheckingAcct in checkingAcctList)
            {
                Console.WriteLine(aCheckingAcct);
            }

            foreach (CD aCDAcct in cDAcctList)
            {
                Console.WriteLine(aCDAcct);
            }

            //allow user to make a deposit into a specific account (call deposit method)
            Console.Write("Please enter the ID for the account into which you want to make a deposit: ");
            int findAcct = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            foreach (Savings aSavingsAccount in savingsAcctList)
            {
                if (aSavingsAccount.acctID == findAcct)
                {
                    Console.WriteLine("The account was found: " + aSavingsAccount);
                    Console.Write("Please enter the amount you'd like to deposit.");
                    found = true;
                }
            }
            if (!(found))
            {
                Console.WriteLine("The account was not found.");
            }


        }
    }
}