using System;

namespace CCPW5
{

    class Program
    {

        static void Main(string[] args)
        {
            // declare variables
            bool userChoice;
            string userChoiceString;
            
            // create lists and list objects
            List<Regular> regularList = new List<Regular>(); 
            List<Executive> executiveList = new List<Executive>(); 
            List<Nonprofit> nonprofitList = new List<Nonprofit>(); 
            List<Corporate> corporateList = new List<Corporate>(); 


            // hard code the test data into the lists
            regularList.Add(new Regular (123, "123@gmail.com", 'R', 60, 162.73, .02));
            regularList.Add(new Regular (456, "456@gmail.com", 'R', 60, 562.81, .02));
            regularList.Add(new Regular (789, "789@gmail.com", 'R', 60, 1247.92, .02));
            
            executiveList.Add(new Executive (100, "100@gmail.com", 'E', 120, 2372.56, .03, .04));
            executiveList.Add(new Executive (101, "101@gmail.com", 'E', 120, 417.06, .03, .04));
            executiveList.Add(new Executive (102, "102@gmail.com", 'E', 120, 972.07, .03, .04));

            nonprofitList.Add(new Nonprofit (200, "200@gmail.com", 'N', 90, 2248.01, .03, 'Y'));
            nonprofitList.Add(new Nonprofit (201, "201@gmail.com", 'N', 90, 948.28, .03, 'N'));
            nonprofitList.Add(new Nonprofit (202, "202@gmail.com", 'N', 90, 1725.92, .03, 'Y'));

            corporateList.Add(new Corporate (300, "300@gmail.com", 'C', 50, 7062.93, .02)); 
            corporateList.Add(new Corporate (301, "301@gmail.com", 'C', 50, 10123.81, .02)); 
            corporateList.Add(new Corporate (302, "302@gmail.com", 'C', 50, 5962.05, .02)); 




//************************************************************************************************************
            // repeat main looop
            do
            {

                // get a valid input
                do
                {
                    // Menu of options
                    Console.WriteLine(); // for user-friendliness in console
                    Console.WriteLine("WHAT WOULD YOU LIKE TO DO?");
                    Console.WriteLine("Administrative Options: ");
                    Console.WriteLine("  C: Create a new membership");
                    Console.WriteLine("  R: Read all of the memberships");
                    Console.WriteLine("  U: Update member information");
                    Console.WriteLine("  D: Delete an existing membership");
                    Console.WriteLine("User Options: ");
                    Console.WriteLine("  L: List all of the memberships in the list");
                    Console.WriteLine("  P: Make a purchase");
                    Console.WriteLine("  T: Return an item");
                    Console.WriteLine("  A: Apply cash-back rewards");
                    Console.WriteLine("  Q: Quit");
                    Console.WriteLine(); // for user-friendliness in console

                    // get valid option from user
                                
                    userChoiceString = Console.ReadLine();
                    userChoice = (userChoiceString == "C" || userChoiceString == "c" ||
                                  userChoiceString == "R" || userChoiceString == "r" ||
                                  userChoiceString == "U" || userChoiceString == "u" ||
                                  userChoiceString == "D" || userChoiceString == "d" ||
                                  userChoiceString == "L" || userChoiceString == "l" ||
                                  userChoiceString == "P" || userChoiceString == "p" ||
                                  userChoiceString == "T" || userChoiceString == "t" ||
                                  userChoiceString == "A" || userChoiceString == "a" ||
                                  userChoiceString == "Q" || userChoiceString == "q");

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option from the menu of actions.");
                    }
                    
                } while (!userChoice);


// Administrative Options ************************************************************************************
                    // -- C -- Create a new membership and add to the membership list.  
                    // *** Be sure you don't duplicate the membership ID.  It needs to be unique.
                    if (userChoiceString=="C" || userChoiceString=="c")
                    {
                        Console.WriteLine("User Choice -- C");

                    } // ends user choice C section


                    // -- R -- Read all of the memberships in the membership list.
                    if (userChoiceString=="R" || userChoiceString=="r")
                    {
                        foreach (Regular aRegular in regularList)
                        { Console.WriteLine(aRegular); }

                        foreach (Executive anExecutive in executiveList)
                        { Console.WriteLine(anExecutive); }

                        foreach (Nonprofit aNonprofit in nonprofitList)
                        { Console.WriteLine(aNonprofit); }

                        foreach (Corporate aCorporate in corporateList)
                        { Console.WriteLine(aCorporate); }

                    } // ends user choice R section


                    // -- U -- Update an existing member's email address based on membership ID.
                                // ~~~ need to make much more concise
                    if (userChoiceString=="U" || userChoiceString=="u")
                    {
                        Console.WriteLine("User Choice -- U");
                        Console.Write("Please enter the Member ID: ");
                        int findMemberID = Int32.Parse(Console.ReadLine());
                        bool found = false;
                        for (int index = 0; index <regularList.Count; index++)
                        {
                            if (regularList[index].memberID == findMemberID)
                            {
                                Console.Write("Regular member " + findMemberID + " found! ");
                                Console.Write("Please enter the new email address: ");
                                string newEmail = Console.ReadLine();
                                Console.Write("Are you sure you want to change the email address from ");
                                Console.Write(regularList[index].email + " to " + newEmail + "? (Y/N) ");
                                string confirmUpdate = Console.ReadLine();
                                if (confirmUpdate == "Y" || confirmUpdate == "y")
                                {
                                    regularList[index].email = newEmail;
                                    Console.WriteLine("The email address has been updated to " + regularList[index].email);
                                }
                                else if (confirmUpdate == "N" || confirmUpdate == "n")
                                {
                                    Console.WriteLine("The email address will not be updated.");
                                }
                                else 
                                {
                                    Console.WriteLine("Please enter either 'Y' for yes, or 'N' for no.");
                                    Console.Write("Are you sure you want to change the email address from ");
                                    Console.Write(regularList[index].email + " to " + newEmail + "? (Y/N) ");
                                    confirmUpdate = Console.ReadLine();
                                    if (confirmUpdate == "Y" || confirmUpdate == "y")
                                    {
                                        regularList[index].email = newEmail;
                                        Console.WriteLine("The email address has been updated to " + regularList[index].email);
                                    }
                                    else if (confirmUpdate == "N" || confirmUpdate == "n")
                                    {
                                        Console.WriteLine("The email address will not be updated.");
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Please start over and enter either 'Y' or 'N' to confirm.");
                                    }
                                }
                                found = true;
                            }  
                        }

                        for (int index = 0; index <executiveList.Count; index++)
                        {
                            if (executiveList[index].memberID == findMemberID)
                            {
                                Console.Write("Executive member " + findMemberID + " found! ");
                                Console.Write("Please enter the new email address: ");
                                string newEmail = Console.ReadLine();
                                Console.Write("Are you sure you want to change the email address from ");
                                Console.Write(executiveList[index].email + " to " + newEmail + "? (Y/N) ");
                                string confirmUpdate = Console.ReadLine();
                                if (confirmUpdate == "Y" || confirmUpdate == "y")
                                {
                                    executiveList[index].email = newEmail;
                                    Console.WriteLine("The email address has been updated to " + executiveList[index].email);
                                }
                                else if (confirmUpdate == "N" || confirmUpdate == "n")
                                {
                                    Console.WriteLine("The email address will not be updated.");
                                }
                                else 
                                {
                                    Console.WriteLine("Please enter either 'Y' for yes, or 'N' for no.");
                                    Console.Write("Are you sure you want to change the email address from ");
                                    Console.Write(executiveList[index].email + " to " + newEmail + "? (Y/N) ");
                                    confirmUpdate = Console.ReadLine();
                                    if (confirmUpdate == "Y" || confirmUpdate == "y")
                                    {
                                        executiveList[index].email = newEmail;
                                        Console.WriteLine("The email address has been updated to " + executiveList[index].email);
                                    }
                                    else if (confirmUpdate == "N" || confirmUpdate == "n")
                                    {
                                        Console.WriteLine("The email address will not be updated.");
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Please start over and enter either 'Y' or 'N' to confirm.");
                                    }
                                }
                                found = true;
                            }  
                        }

                        for (int index = 0; index <nonprofitList.Count; index++)
                        {
                            if (nonprofitList[index].memberID == findMemberID)
                            {
                                Console.Write("Nonprofit member " + findMemberID + " found! ");
                                Console.Write("Please enter the new email address: ");
                                string newEmail = Console.ReadLine();
                                Console.Write("Are you sure you want to change the email address from ");
                                Console.Write(nonprofitList[index].email + " to " + newEmail + "? (Y/N) ");
                                string confirmUpdate = Console.ReadLine();
                                if (confirmUpdate == "Y" || confirmUpdate == "y")
                                {
                                    nonprofitList[index].email = newEmail;
                                    Console.WriteLine("The email address has been updated to " + nonprofitList[index].email);
                                }
                                else if (confirmUpdate == "N" || confirmUpdate == "n")
                                {
                                    Console.WriteLine("The email address will not be updated.");
                                }
                                else 
                                {
                                    Console.WriteLine("Please enter either 'Y' for yes, or 'N' for no.");
                                    Console.Write("Are you sure you want to change the email address from ");
                                    Console.Write(nonprofitList[index].email + " to " + newEmail + "? (Y/N) ");
                                    confirmUpdate = Console.ReadLine();
                                    if (confirmUpdate == "Y" || confirmUpdate == "y")
                                    {
                                        nonprofitList[index].email = newEmail;
                                        Console.WriteLine("The email address has been updated to " + nonprofitList[index].email);
                                    }
                                    else if (confirmUpdate == "N" || confirmUpdate == "n")
                                    {
                                        Console.WriteLine("The email address will not be updated.");
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Please start over and enter either 'Y' or 'N' to confirm.");
                                    }
                                }
                                found = true;
                            }  
                        }

                        for (int index = 0; index <corporateList.Count; index++)
                        {
                            if (corporateList[index].memberID == findMemberID)
                            {
                                Console.Write("Corporate member " + findMemberID + " found! ");
                                Console.Write("Please enter the new email address: ");
                                string newEmail = Console.ReadLine();
                                Console.Write("Are you sure you want to change the email address from ");
                                Console.Write(corporateList[index].email + " to " + newEmail + "? (Y/N) ");
                                string confirmUpdate = Console.ReadLine();
                                if (confirmUpdate == "Y" || confirmUpdate == "y")
                                {
                                    corporateList[index].email = newEmail;
                                    Console.WriteLine("The email address has been updated to " + corporateList[index].email);
                                }
                                else if (confirmUpdate == "N" || confirmUpdate == "n")
                                {
                                    Console.WriteLine("The email address will not be updated.");
                                }
                                else 
                                {
                                    Console.WriteLine("Please enter either 'Y' for yes, or 'N' for no.");
                                    Console.Write("Are you sure you want to change the email address from ");
                                    Console.Write(corporateList[index].email + " to " + newEmail + "? (Y/N) ");
                                    confirmUpdate = Console.ReadLine();
                                    if (confirmUpdate == "Y" || confirmUpdate == "y")
                                    {
                                        corporateList[index].email = newEmail;
                                        Console.WriteLine("The email address has been updated to " + corporateList[index].email);
                                    }
                                    else if (confirmUpdate == "N" || confirmUpdate == "n")
                                    {
                                        Console.WriteLine("The email address will not be updated.");
                                    }
                                    else 
                                    {
                                        Console.WriteLine("Please start over and enter either 'Y' or 'N' to confirm.");
                                    }
                                }
                                found = true;
                            }  
                        }
                        if (found == false)
                        {
                            Console.WriteLine("The Member ID was not found. ");
                        }
                    } // ends user choice U section



                    // -- D -- Delete an existing membership based on membership ID.
                                // ~~~ need to make much more concise                    
                    if (userChoiceString=="D" || userChoiceString=="d")
                    {
                        Console.WriteLine("User Choice -- D");
                        Console.Write("Please enter the Member ID: ");
                        int findMemberID = Int32.Parse(Console.ReadLine());
                        bool found = false;
                        for (int index = 0; index <regularList.Count; index++)
                        {
                            if (regularList[index].memberID == findMemberID)
                            {
                                Console.Write("Regular member " + findMemberID + " found! ");
                                Console.Write("Are you sure you want to delete this member? ('Y'/'N/) ");
                                string confirmDelete = Console.ReadLine();
                                if (confirmDelete == "Y" || confirmDelete == "y")
                                {
                                    Console.WriteLine("Member " + regularList[index].memberID + " has been deleted. ");
                                    regularList.RemoveAt(index);
                                    found = true;
                                }
                                else if (confirmDelete == "N" || confirmDelete == "n")
                                {
                                    Console.WriteLine("Got it. The member will not be deleted. ");
                                }
                                else 
                                {
                                    Console.Write("Please enter either 'Y' for yes, or 'N' for no. Do you want to delete the member?");
                                    confirmDelete = Console.ReadLine();
                                    if (confirmDelete == "Y" || confirmDelete == "y")
                                    {
                                        regularList.RemoveAt(index);
                                        Console.WriteLine("Member " + regularList[index].memberID + " has been deleted. ");
                                        found = true;
                                    }
                                    else if (confirmDelete == "N" || confirmDelete == "n")
                                    {
                                        Console.WriteLine("Got it. The member will not be deleted. ");
                                    }
                                    else 
                                    {
                                        Console.Write("Please start over and enter either 'Y' or 'N' to confirm.");
                                    }
                                }
                            }
                        }

                        for (int index = 0; index <executiveList.Count; index++)
                        {
                            if (executiveList[index].memberID == findMemberID)
                            {
                                Console.Write("Executive member " + findMemberID + " found! ");
                                Console.Write("Are you sure you want to delete this member? ('Y'/'N/) ");
                                string confirmDelete = Console.ReadLine();
                                if (confirmDelete == "Y" || confirmDelete == "y")
                                {
                                    Console.WriteLine("Member " + executiveList[index].memberID + " has been deleted. ");
                                    executiveList.RemoveAt(index);
                                    found = true;
                                }
                                else if (confirmDelete == "N" || confirmDelete == "n")
                                {
                                    Console.WriteLine("Got it. The member will not be deleted. ");
                                }
                                else 
                                {
                                    Console.Write("Please enter either 'Y' for yes, or 'N' for no. Do you want to delete the member?");
                                    confirmDelete = Console.ReadLine();
                                    if (confirmDelete == "Y" || confirmDelete == "y")
                                    {
                                        executiveList.RemoveAt(index);
                                        Console.WriteLine("Member " + executiveList[index].memberID + " has been deleted. ");
                                        found = true;
                                    }
                                    else if (confirmDelete == "N" || confirmDelete == "n")
                                    {
                                        Console.WriteLine("Got it. The member will not be deleted. ");
                                    }
                                    else 
                                    {
                                        Console.Write("Please start over and enter either 'Y' or 'N' to confirm.");
                                    }
                                }
                            }
                        }

                        for (int index = 0; index <nonprofitList.Count; index++)
                        {
                            if (nonprofitList[index].memberID == findMemberID)
                            {
                                Console.Write("Nonprofit member " + findMemberID + " found! ");
                                Console.Write("Are you sure you want to delete this member? ('Y'/'N/) ");
                                string confirmDelete = Console.ReadLine();
                                if (confirmDelete == "Y" || confirmDelete == "y")
                                {
                                    Console.WriteLine("Member " + nonprofitList[index].memberID + " has been deleted. ");
                                    nonprofitList.RemoveAt(index);
                                    found = true;
                                }
                                else if (confirmDelete == "N" || confirmDelete == "n")
                                {
                                    Console.WriteLine("Got it. The member will not be deleted. ");
                                }
                                else 
                                {
                                    Console.Write("Please enter either 'Y' for yes, or 'N' for no. Do you want to delete the member?");
                                    confirmDelete = Console.ReadLine();
                                    if (confirmDelete == "Y" || confirmDelete == "y")
                                    {
                                        nonprofitList.RemoveAt(index);
                                        Console.WriteLine("Member " + nonprofitList[index].memberID + " has been deleted. ");
                                        found = true;
                                    }
                                    else if (confirmDelete == "N" || confirmDelete == "n")
                                    {
                                        Console.WriteLine("Got it. The member will not be deleted. ");
                                    }
                                    else 
                                    {
                                        Console.Write("Please start over and enter either 'Y' or 'N' to confirm.");
                                    }
                                }
                            }
                        }

                        for (int index = 0; index <nonprofitList.Count; index++)
                        {    
                            if (corporateList[index].memberID == findMemberID)
                            {
                                Console.Write("Corporate member " + findMemberID + " found! ");
                                Console.Write("Are you sure you want to delete this member? ('Y'/'N/) ");
                                string confirmDelete = Console.ReadLine();
                                if (confirmDelete == "Y" || confirmDelete == "y")
                                {
                                    Console.WriteLine("Member " + corporateList[index].memberID + " has been deleted. ");
                                    corporateList.RemoveAt(index);
                                    found = true;
                                }
                                else if (confirmDelete == "N" || confirmDelete == "n")
                                {
                                    Console.WriteLine("Got it. The member will not be deleted. ");
                                }
                                else 
                                {
                                    Console.Write("Please enter either 'Y' for yes, or 'N' for no. Do you want to delete the member?");
                                    confirmDelete = Console.ReadLine();
                                    if (confirmDelete == "Y" || confirmDelete == "y")
                                    {
                                        corporateList.RemoveAt(index);
                                        Console.WriteLine("Member " + corporateList[index].memberID + " has been deleted. ");
                                        found = true;
                                    }
                                    else if (confirmDelete == "N" || confirmDelete == "n")
                                    {
                                        Console.WriteLine("Got it. The member will not be deleted. ");
                                    }
                                    else 
                                    {
                                        Console.Write("Please start over and enter either 'Y' or 'N' to confirm.");
                                    }
                                }
                            }
                        }
                        if (found == false)
                        {
                            Console.WriteLine("The Member ID was not found. ");
                        }                        
                    } // ends user choice D section


// User Options **********************************************************************************************
                    // -- L -- List all of the memberships in the list including all of the information for each account type.
                    if (userChoiceString=="L" || userChoiceString=="l")
                    {
                        Console.WriteLine("User Choice -- L");

                    } // ends user choice L section


                    // -- P -- Perform a purchase transaction (get membership ID and purchase amount from user. 
                                // if membership exists, add the purchase amount to the monthly purchase total.)
                    if (userChoiceString=="P" || userChoiceString=="p")
                    {
                        Console.WriteLine("User Choice -- P");
                        Console.Write("Please enter the Member ID for the purchase: ");
                        int findMemberID = Int32.Parse(Console.ReadLine());
                        bool found = false;
                        for (int index = 0; index <regularList.Count; index++)
                        {
                            if (regularList[index].memberID == findMemberID)
                            {
                                Console.Write("Regular member " + findMemberID + " found! ");
                                regularList[index].Purchase(); // calling method here
                                Console.Write("Current Purchase Per Month Total: " + regularList[index].currentPFM);
                            }
                        }

                        for (int index = 0; index <executiveList.Count; index++)
                        {
                            if (executiveList[index].memberID == findMemberID)
                            {
                                Console.Write("Executive member " + findMemberID + " found! ");
                                executiveList[index].Purchase(); // calling method here
                                Console.Write("Current Purchase Per Month Total: " + executiveList[index].currentPFM);
                            }
                        }

                        for (int index = 0; index <nonprofitList.Count; index++)
                        {
                            if (nonprofitList[index].memberID == findMemberID)
                            {
                                Console.Write("Nonprofit member " + findMemberID + " found! ");
                                nonprofitList[index].Purchase(); // calling method here
                                Console.Write("Current Purchase Per Month Total: " + nonprofitList[index].currentPFM);
                            }
                        }

                        for (int index = 0; index <corporateList.Count; index++)
                        {
                            if (corporateList[index].memberID == findMemberID)
                            {
                                Console.Write("Corporate member " + findMemberID + " found! ");
                                corporateList[index].Purchase(); // calling method here
                                Console.Write("Current Purchase Per Month Total: " + corporateList[index].currentPFM);
                            }
                        }

                        /* if (found == false)
                        {
                            Console.WriteLine("The Member ID was not found. ");
                        } */  
                        

                    } // ends user choice P section


                    // -- T -- Perform a return transaction (get member ID and return amount from the user. 
                                // if membership exists, perform the return by subtracting the return amount for the monthly purchase total.
                    if (userChoiceString=="T" || userChoiceString=="t")
                    {
                        Console.WriteLine("User Choice -- T");
                        Console.Write("Please enter the Member ID for the return: ");
                        int findMemberID = Int32.Parse(Console.ReadLine());
                        bool found = false;
                        for (int index = 0; index <regularList.Count; index++)
                        {
                            if (regularList[index].memberID == findMemberID)
                            {
                                Console.Write("Regular member " + findMemberID + " found! ");
                                regularList[index].Return(); // calling method here
                                Console.Write("Current Purchase Per Month Total: " + regularList[index].currentPFM);
                            }
                        }

                        for (int index = 0; index <executiveList.Count; index++)
                        {
                            if (executiveList[index].memberID == findMemberID)
                            {
                                Console.Write("Executive member " + findMemberID + " found! ");
                                executiveList[index].Return(); // calling method here
                                Console.Write("Current Purchase Per Month Total: " + executiveList[index].currentPFM);
                            }
                        }

                        for (int index = 0; index <nonprofitList.Count; index++)
                        {
                            if (nonprofitList[index].memberID == findMemberID)
                            {
                                Console.Write("Nonprofit member " + findMemberID + " found! ");
                                nonprofitList[index].Return(); // calling method here
                                Console.Write("Current Purchase Per Month Total: " + nonprofitList[index].currentPFM);
                            }
                        }

                        for (int index = 0; index <corporateList.Count; index++)
                        {
                            if (corporateList[index].memberID == findMemberID)
                            {
                                Console.Write("Corporate member " + findMemberID + " found! ");
                                corporateList[index].Return(); // calling method here
                                Console.Write("Current Purchase Per Month Total: " + corporateList[index].currentPFM);
                            }
                        }
                        
                        /* if (found == false)
                        {
                            Console.WriteLine("The Member ID was not found. ");
                        }  */ 

                    } // ends user choice T section


                    // -- A -- Apply cash-back rewards as described above by getting a membership number from the user.
                    if (userChoiceString=="A" || userChoiceString=="a")
                    {
                        Console.WriteLine("User Choice -- A");

                    } // ends user choice A section


//************************************************************************************************************

            // -- Q -- Quit the transaction processing
            } while (!(userChoiceString=="Q") && !(userChoiceString=="q")); // bracket ends 'repeat main loop'
            {
                Console.WriteLine("Have a nice day!");
            } // ends user choice A section

        }
    }
}