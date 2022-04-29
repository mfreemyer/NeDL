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

                //get a valid input
                do
                {
                    //Menu of options
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

                        // print the lists
                        if (userChoiceString=="L" || userChoiceString=="l")
                        {
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

                        }

                        //allow user to make a deposit into a specific account (call deposit method)
                        else if (userChoiceString=="D" || userChoiceString=="d")
                        {
                            Console.Write("Please enter the ID for the account into which you want to make a deposit: ");
                            int findAcct = Convert.ToInt32(Console.ReadLine());
                            bool found = false;
                            for (int index = 0; index < savingsAcctList.Count; index++)
                            {
                                if (savingsAcctList[index].acctID == findAcct)
                                {
                                    Console.WriteLine("The account (" + savingsAcctList[index].acctID + ") was found.  The current balance is " + savingsAcctList[index].acctBal);
                                    Console.Write("Please enter the amount you'd like to deposit: ");
                                    double newDepositAmt = Convert.ToDouble(Console.ReadLine());
                                    // Account.Deposit(newDepositAmt); 
                                    // error CS0120: An object reference is required for the non-static field, method, or property 'Account.Deposit(double)'
                                    savingsAcctList[index].Deposit(newDepositAmt);
                                    Console.WriteLine(savingsAcctList[index].acctBal);
                                    found = true;
                                }
                            }
                        }

                        //allow user to make a withdrawal from a specific account 
                        else if (userChoiceString=="W" || userChoiceString=="w")
                        {
                            Console.WriteLine("Zoiks! There's no code in the withdrawal section yet!!! :D ");

                        }
            
            
            
            
            // Q -- Quit the program
            } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
            {
                Console.WriteLine("Have a nice day!");
            } //ends 'repeat main loop'



        }
    }
}