using System;

namespace ccpw4
{

    class Program
    {

        static void Main(string[] args)
        {
            
            // declare variables
            bool userChoice;
            string userChoiceString;
            
            // create lists (and list objects?)
            List<Account> accountList = new List<Account>();

            // hard code the data into the lists
            accountList.Add(new Savings(012345678, 7323.08, "S", .01));
            accountList.Add(new Savings(876543210, 10528.72, "S", .01));

            accountList.Add(new Checking(123456789, 3000.05, "Ch", 50));
            accountList.Add(new Checking(987654321, 800.17, "Ch", 50));

            accountList.Add(new CD(789456123, 20000.00, "CD", .1));
            accountList.Add(new CD(321654987, 80.48, "CD", .1));

            //*****************************************************************************************************
            // repeat main looop
            do
            {
                // get a valid input
                do
                {
                    // Menu of options
                    Console.WriteLine("WHAT WOULD YOU LIKE TO DO?");
                    Console.WriteLine("L: List all of the accounts and their information");
                    Console.WriteLine("D: Make a deposit");
                    Console.WriteLine("W: Make a withdrawal");
                    Console.WriteLine("Q: Quit the program");

                    // get valid option from user
                                
                    userChoiceString = Console.ReadLine();
                    userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                                    userChoiceString == "D" || userChoiceString == "d" ||
                                    userChoiceString == "W" || userChoiceString == "w" ||
                                    userChoiceString == "Q" || userChoiceString == "q");

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option from the list.");
                    }
                    
                } while (!userChoice);

//*****************************************************************************************************

                // -- L -- print the lists
                if (userChoiceString=="L" || userChoiceString=="l")
                {
                    Console.WriteLine(); // for user friendliness in terminal
                    foreach (Account anAccount in accountList)
                    { Console.WriteLine(anAccount); }
                    
                    Console.WriteLine(); // for user friendliness in terminal

                } // ends print lists section


                // -- D -- allow user to make a deposit into a specific account (call deposit method)
                else if (userChoiceString=="D" || userChoiceString=="d")
                { 
                    // get the account number from user and perform the deposit 
                    Console.Write("Please enter the ID for the account into which you want to make a deposit: ");
                    int findAcct = Convert.ToInt32(Console.ReadLine());
                    bool found = false;
                    for (int index = 0; index < accountList.Count; index++)
                    {    
                        if (accountList[index].acctID == findAcct)
                        {
                            Console.Write("The account (" + accountList[index].acctID + ") was found!");  
                            Console.WriteLine("  The current balance is " + String.Format("${0:n}",accountList[index].acctBal));
                            Console.Write("Please enter the amount you'd like to deposit: ");
                            double newDepositAmt = Convert.ToDouble(Console.ReadLine());
                            accountList[index].Deposit(newDepositAmt); // calling method here
                            Console.WriteLine(String.Format("${0:n}",(accountList[index].acctBal)));
                            Console.WriteLine();
                            found = true;
                        } 
                    }

                    while (found == false)
                        {
                            Console.Write("The account number entered is invalid. Please try again: ");
                            findAcct = Convert.ToInt32(Console.ReadLine());
                            found = false;
                            for (int index = 0; index < accountList.Count; index++)
                            {    
                                if (accountList[index].acctID == findAcct)
                                {
                                    Console.Write("The account (" + accountList[index].acctID + ") was found!");  
                                    Console.WriteLine("  The current balance is " + String.Format("${0:n}",accountList[index].acctBal));
                                    Console.Write("Please enter the amount you'd like to deposit: ");
                                    double newDepositAmt = Convert.ToDouble(Console.ReadLine());
                                    accountList[index].Deposit(newDepositAmt); // calling method here
                                    Console.WriteLine(String.Format("${0:n}",(accountList[index].acctBal)));
                                    Console.WriteLine();
                                    found = true;
                                } 
                            }
                        }
                } // ends user choice deposit section


                // -- W -- allow user to make a withdrawal from a specific account 
                else if (userChoiceString=="W" || userChoiceString=="w")
                {
                    // get the account number from the user
                    Console.Write("Please enter the ID for the account from which you want to withdraw funds: ");
                    int findAcct = Convert.ToInt32(Console.ReadLine());
                    bool found = false; 
                    for (int index = 0; index < accountList.Count; index++)
                    {
                        if (accountList[index].acctID == findAcct)
                        {
                            Console.Write("The account (" + accountList[index].acctID + ") was found!");  
                            Console.WriteLine("  The current balance is " + String.Format("${0:n}",(accountList[index].acctBal)));
                            accountList[index].Withdrawal(); // calling method (and the power of polymorphism!) here
                            Console.WriteLine(String.Format("${0:n}",(accountList[index].acctBal)));
                            Console.WriteLine();
                            found = true;
                        }
                    }

                    while (found == false) 
                    {
                        Console.Write("The account number entered is invalid. Please try again: ");
                        findAcct = Convert.ToInt32(Console.ReadLine());
                        found = false; 
                        for (int index = 0; index < accountList.Count; index++)
                        {
                            if (accountList[index].acctID == findAcct)
                            {
                                Console.Write("The account (" + accountList[index].acctID + ") was found!");  
                                Console.WriteLine("  The current balance is " + String.Format("${0:n}",(accountList[index].acctBal)));
                                accountList[index].Withdrawal(); // calling method (and the power of polymorphism!) here
                                Console.WriteLine(String.Format("${0:n}",(accountList[index].acctBal)));
                                Console.WriteLine();
                                found = true;
                            }
                        }
                    } 

                } // ends user choice withdrawal section
        
            
            // -- Q -- Quit the program
            } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
            {
                Console.WriteLine("Have a nice day!");
            } // ends 'repeat main loop'
        }
    }
}