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
            List<Savings> savingsAcctList = new List<Savings>();
            List<Checking> checkingAcctList = new List<Checking>();
            List<CD> cDAcctList = new List<CD>();

            // hard code the data into the lists
            savingsAcctList.Add(new Savings (012345678, 7323.08, "S", .01));
            savingsAcctList.Add(new Savings (876543210, 10528.72, "S", .01));
            
            checkingAcctList.Add(new Checking (123456789, 3000.05, "Ch", 2));
            checkingAcctList.Add(new Checking (987654321, 800.17, "Ch", 2));

            cDAcctList.Add(new CD (789456123, 20000.00, "CD", .1));
            cDAcctList.Add(new CD (321654987, 80.48, "CD", .1));        

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
                    foreach (Savings aSavingsAcct in savingsAcctList)
                    { Console.WriteLine(aSavingsAcct); }
                    
                    foreach (Checking aCheckingAcct in checkingAcctList)
                    { Console.WriteLine(aCheckingAcct); }

                    foreach (CD aCDAcct in cDAcctList)
                    { Console.WriteLine(aCDAcct); }
                    Console.WriteLine(); // for user friendliness in terminal

                } // ends print lists section


                // -- D -- allow user to make a deposit into a specific account (call deposit method)
                // **** should/can i include more of this in the actual method in Account.cs for DRY Principle? 
                else if (userChoiceString=="D" || userChoiceString=="d")
                {
                    // get the account type from user
                    Console.WriteLine("What type of account are you depositing into?");
                    Console.Write("Please enter 'S' for Savings, 'Ch' for Checking, or CD for a CD Account: ");
                    string selectAcctType = Console.ReadLine();
                    switch (selectAcctType)
                    {
                        case "S":
                        case "s":
                            Console.WriteLine(); 
                            // get the savings account number from user and perform the deposit 
                            Console.Write("Please enter the ID for the savings account into which you want to make a deposit: ");
                            int findAcct = Convert.ToInt32(Console.ReadLine());
                            bool found = false;
                            for (int index = 0; index < savingsAcctList.Count; index++)
                            {
                                if (savingsAcctList[index].acctID == findAcct)
                                {
                                    Console.Write("The savings account (" + savingsAcctList[index].acctID + ") was found!");  
                                    Console.WriteLine("  The current balance is " + savingsAcctList[index].acctBal);
                                    Console.Write("Please enter the amount you'd like to deposit: ");
                                    double newDepositAmt = Convert.ToDouble(Console.ReadLine());
                                    savingsAcctList[index].Deposit(newDepositAmt);
                                    Console.WriteLine(savingsAcctList[index].acctBal);
                                    Console.WriteLine();
                                    found = true;
                                }
                            }
                        break;
                        case "Ch":
                        case "CH":
                        case "ch":
                            Console.WriteLine();
                            // get the checking account number from user and perform the deposit 
                            Console.Write("Please enter the ID for the checking account into which you want to make a deposit: ");
                            findAcct = Convert.ToInt32(Console.ReadLine());
                            found = false;
                            for (int index = 0; index < checkingAcctList.Count; index++)
                            {
                                if (checkingAcctList[index].acctID == findAcct)
                                {
                                    Console.Write("The checking account (" + checkingAcctList[index].acctID + ") was found!");
                                    Console.WriteLine("  The current balance is " + checkingAcctList[index].acctBal);
                                    Console.Write("Please enter the amount you'd like to deposit: ");
                                    double newDepositAmt = Convert.ToDouble(Console.ReadLine());
                                    checkingAcctList[index].Deposit(newDepositAmt);
                                    Console.WriteLine(checkingAcctList[index].acctBal);
                                    Console.WriteLine();
                                    found = true;
                                }
                            }
                        break; 
                        case "CD":
                        case "Cd":
                        case "cd":
                            Console.WriteLine();
                            // get the CD account number from user and perform the deposit 
                            Console.Write("Please enter the ID for the CD account into which you want to make a deposit: ");
                            findAcct = Convert.ToInt32(Console.ReadLine());
                            found = false;
                            for (int index = 0; index < cDAcctList.Count; index++)
                            {
                                if (cDAcctList[index].acctID == findAcct)
                                {
                                    Console.Write("The CD account (" + cDAcctList[index].acctID + ") was found!");
                                    Console.WriteLine("  The current balance is " + cDAcctList[index].acctBal);
                                    Console.Write("Please enter the amount you'd like to deposit: ");
                                    double newDepositAmt = Convert.ToDouble(Console.ReadLine());
                                    cDAcctList[index].Deposit(newDepositAmt); // calling the method here
                                    Console.WriteLine(cDAcctList[index].acctBal);
                                    Console.WriteLine();
                                    found = true;
                                }
                            }
                        break;
                        default:
                            Console.WriteLine("The option you entered is invalid. Select 'D' for Deposit and try again.");
                            // add option to try again here if time
                        break;
                    }

                } // ends user choice deposit section


                // -- W -- allow user to make a withdrawal from a specific account 
                else if (userChoiceString=="W" || userChoiceString=="w")
                {
                    // get the savings account number from the user
                    Console.Write("Please enter the ID for the savings account from which you want to withdraw funds: ");
                    int findAcct = Convert.ToInt32(Console.ReadLine());
                    bool found = false; 
                    for (int index = 0; index < savingsAcctList.Count; index++)
                    {
                        if (savingsAcctList[index].acctID == findAcct)
                        {
                            Console.Write("The savings account (" + savingsAcctList[index].acctID + ") was found!");  
                            Console.WriteLine("  The current balance is " + savingsAcctList[index].acctBal);
                            savingsAcctList[index].Withdrawal(); // calling method here
                            Console.WriteLine(savingsAcctList[index].acctBal);
                            Console.WriteLine();
                            found = true;

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