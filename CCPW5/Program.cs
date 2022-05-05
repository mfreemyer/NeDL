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
            
            // create list and list objects
            List<Membership> membershipList = new List<Membership>();


            // hard code the test data into the list
            membershipList.Add(new Regular (123, "123@gmail.com", 'R', 60, 162.73, .02));
            membershipList.Add(new Regular (456, "456@gmail.com", 'R', 60, 562.81, .02));
            membershipList.Add(new Regular (789, "789@gmail.com", 'R', 60, 1247.92, .02));
            
            membershipList.Add(new Executive (100, "100@gmail.com", 'E', 120, 2372.56, .03, .04));
            membershipList.Add(new Executive (101, "101@gmail.com", 'E', 120, 417.06, .03, .04));
            membershipList.Add(new Executive (102, "102@gmail.com", 'E', 120, 972.07, .03, .04));

            membershipList.Add(new Nonprofit (200, "200@gmail.com", 'N', 90, 2248.01, .03, 'Y'));
            membershipList.Add(new Nonprofit (201, "201@gmail.com", 'N', 90, 948.28, .03, 'N'));
            membershipList.Add(new Nonprofit (202, "202@gmail.com", 'N', 90, 1725.92, .03, 'Y'));

            membershipList.Add(new Corporate (300, "300@gmail.com", 'C', 50, 7062.93, .02)); 
            membershipList.Add(new Corporate (301, "301@gmail.com", 'C', 50, 10123.81, .02)); 
            membershipList.Add(new Corporate (302, "302@gmail.com", 'C', 50, 5962.05, .02)); 




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
                        bool found = false;
                        do 
                        {
                            Console.Write("Please enter the new Member ID: ");
                            int newMemberID = Int32.Parse(Console.ReadLine());
                            found = false;
                            for (int index = 0; index <membershipList.Count; index++)
                            {
                                if (membershipList[index].memberID == newMemberID)
                                {
                                    Console.WriteLine("This member ID is already taken. Please select C again to try another number. ");
                                    found = true;
                                }
                            }

                        } while (found);
                                                
                        Console.WriteLine("What type of member is being added? Please enter one of the following: ");
                        Console.WriteLine("  'R' for a regular membership. ");
                        Console.WriteLine("  'E' for an executive membership. ");
                        Console.WriteLine("  'N' for a non-profit membership. ");
                        Console.Write("  'C' for a corporate membership. ");
                        char newMemberType = Convert.ToChar(Console.ReadLine());
                        switch (newMemberType)
                        {
                            case 'R':
                            case 'r':
                                Console.WriteLine("R was selected.");
                                string newEmail = Console.ReadLine();
                            break;
                            case 'E':
                            case 'e':
                                Console.WriteLine("E was selected.");
                            break;
                            case 'N':
                            case 'n':
                                Console.WriteLine("N was selected.");
                            break;
                            case 'C':
                            case 'c':
                                Console.WriteLine("C was selected.");
                            break;
                            default:
                                Console.WriteLine("That option is invalid. Please select one of the above-listed options.");
                                newMemberType = Convert.ToChar(Console.ReadLine());
                            break;

                            }
                        

 

                    } // ends user choice C section


                    // -- R -- Read all of the memberships in the membership list.
                    if (userChoiceString=="R" || userChoiceString=="r")
                    {
                        foreach (Membership aMembership in membershipList)
                        { Console.WriteLine(aMembership); }

                        Console.WriteLine("* CPFM = Current Purchases For Month  |  * CBR = Cash-Back Reward");

                    } // ends user choice R section


                    // -- U -- Update an existing member's email address based on membership ID.
                    if (userChoiceString=="U" || userChoiceString=="u")
                    {
                        Console.WriteLine("User Choice -- U");
                        Console.Write("Please enter the Member ID: ");
                        int findMemberID = Int32.Parse(Console.ReadLine());
                        bool found = false;
                        for (int index = 0; index <membershipList.Count; index++)
                        {
                            if (membershipList[index].memberID == findMemberID)
                            {
                                Console.Write("Member " + findMemberID + " found! ");
                                Console.Write("Please enter the new email address: ");
                                string newEmail = Console.ReadLine();
                                Console.Write("Are you sure you want to change the email address from ");
                                Console.Write(membershipList[index].email + " to " + newEmail + "? (Y/N) ");
                                string confirmUpdate = Console.ReadLine();
                                if (confirmUpdate == "Y" || confirmUpdate == "y")
                                {
                                    membershipList[index].email = newEmail;
                                    Console.WriteLine("The email address has been updated to " + membershipList[index].email);
                                }
                                else if (confirmUpdate == "N" || confirmUpdate == "n")
                                {
                                    Console.WriteLine("The email address will not be updated.");
                                }
                                else 
                                {
                                    Console.WriteLine("Please enter either 'Y' for yes, or 'N' for no.");
                                    Console.Write("Are you sure you want to change the email address from ");
                                    Console.Write(membershipList[index].email + " to " + newEmail + "? (Y/N) ");
                                    confirmUpdate = Console.ReadLine();
                                    if (confirmUpdate == "Y" || confirmUpdate == "y")
                                    {
                                        membershipList[index].email = newEmail;
                                        Console.WriteLine("The email address has been updated to " + membershipList[index].email);
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
                    if (userChoiceString=="D" || userChoiceString=="d")
                    {
                        Console.WriteLine("User Choice -- D");
                        Console.Write("Please enter the Member ID: ");
                        int findMemberID = Int32.Parse(Console.ReadLine());
                        bool found = false;
                        for (int index = 0; index <membershipList.Count; index++)
                        {
                            if (membershipList[index].memberID == findMemberID)
                            {
                                Console.Write("Member " + findMemberID + " found! ");
                                Console.Write("Are you sure you want to delete this member? ('Y'/'N/) ");
                                string confirmDelete = Console.ReadLine();
                                if (confirmDelete == "Y" || confirmDelete == "y")
                                {
                                    Console.WriteLine("Member " + membershipList[index].memberID + " has been deleted. ");
                                    membershipList.RemoveAt(index);
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
                                        membershipList.RemoveAt(index);
                                        Console.WriteLine("Member " + membershipList[index].memberID + " has been deleted. ");
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
                        foreach (Membership aMember in membershipList)
                        { Console.WriteLine(aMember); }
                        Console.WriteLine("* CPFM = Current Purchases For Month  |  * CBR = Cash-Back Reward");

                    } // ends user choice L section


                    // -- P -- Perform a purchase transaction (get membership ID and purchase amount from user. 
                                // if membership exists, add the purchase amount to the monthly purchase total.)
                    if (userChoiceString=="P" || userChoiceString=="p")
                    {
                        Console.WriteLine("User Choice -- P");
                        Console.Write("Please enter the Member ID for the purchase: ");
                        int findMemberID = Int32.Parse(Console.ReadLine());
                        bool found = false;
                        for (int index = 0; index <membershipList.Count; index++)
                        {
                            if (membershipList[index].memberID == findMemberID)
                            {
                                Console.Write("Regular member " + findMemberID + " found! ");
                                membershipList[index].Purchase(); // calling method here
                                Console.Write("Current Purchase Per Month Total: " + membershipList[index].currentPFM);
                                found = true;
                            }
                        }


                        if (found == false)
                        {
                            Console.WriteLine("The Member ID was not found. ");
                        } 
                        

                    } // ends user choice P section


                    // -- T -- Perform a return transaction (get member ID and return amount from the user. 
                                // if membership exists, perform the return by subtracting the return amount for the monthly purchase total.
                    if (userChoiceString=="T" || userChoiceString=="t")
                    {
                        Console.WriteLine("User Choice -- T");
                        Console.Write("Please enter the Member ID for the return: ");
                        int findMemberID = Int32.Parse(Console.ReadLine());
                        bool found = false;
                        for (int index = 0; index <membershipList.Count; index++)
                        {
                            if (membershipList[index].memberID == findMemberID)
                            {
                                Console.Write("Member " + findMemberID + " found! ");
                                membershipList[index].Return(); // calling method here
                                Console.Write("Current Purchase Per Month Total: " + membershipList[index].currentPFM);
                                found = true;
                            }
                        }
                        
                        if (found == false)
                        {
                            Console.WriteLine("The Member ID was not found. ");
                        }  

                    } // ends user choice T section


                    // -- A -- Apply cash-back rewards as described above by getting a membership number from the user.
                    if (userChoiceString=="A" || userChoiceString=="a")
                    {
                        Console.WriteLine("User Choice -- A");
                        Console.Write("Please enter the Member ID for the return: ");
                        int findMemberID = Int32.Parse(Console.ReadLine());
                        bool found = false;
                        for (int index = 0; index <membershipList.Count; index++)
                        {
                            if (membershipList[index].memberID == findMemberID)
                            {
                                Console.Write("Regular member " + findMemberID + " found! ");
                                membershipList[index].ApplyCBR(); // calling method here
                                found = true;
                            }
                        }

                        if (found == false)
                        {
                            Console.WriteLine("The Member ID was not found. ");
                        }  

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