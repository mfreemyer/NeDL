using System;
using System.IO;

namespace CRUDapp
{
  class Program
  {
    static void Main(string[] args)
    {

      // declare variables
      bool userChoice;
      string userChoiceString;
      string[] nameArray = new string[10];

      // repeat main loop
      do
      {

            // to do: get a valid input
                do
                {
                    // initialize variables

                    userChoice = false;
                    
                    // to do: provide user a menu of options

                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("L: Load the data file into an array.");
                    Console.WriteLine("S: Store the array of strings into the text file.");
                    Console.WriteLine("C: Add a name to the array.");
                    Console.WriteLine("R: Read a name from the array.");
                    Console.WriteLine("U: Update a name in the array.");
                    Console.WriteLine("D: Delete the name in the array.");
                    Console.WriteLine("Q: Quit the program.");

                    // to do: get a valid user option (valid means it's on the menu)

                    userChoiceString = Console.ReadLine();
                    
                    userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                                  userChoiceString == "S" || userChoiceString == "s" ||
                                  userChoiceString == "C" || userChoiceString == "c" ||
                                  userChoiceString == "R" || userChoiceString == "r" ||
                                  userChoiceString == "U" || userChoiceString == "u" ||
                                  userChoiceString == "D" || userChoiceString == "d" ||
                                  userChoiceString == "Q" || userChoiceString == "q");

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                } while (!userChoice);

            // to do: if the option is L or l then load the text file (names.txt) into the array of strings (nameArray)
            // change 
            // another change

           if (userChoiceString=="L" || userChoiceString=="l")
            {
                Console.WriteLine("In the L/l area");
                int index = 0; // index for my array
                using (StreamReader sr = File.OpenText("names.txt"))
                {
                    string s = "";
                    Console.WriteLine("Here is the content of the file names.txt: ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        nameArray[index] = s;
                        index = index + 1;
                    }
                
                }
            
            }

            // to do: else if the option is an S or s then store the array of strings into the text file

            else if (userChoiceString=="S" || userChoiceString=="s")
            {
                Console.WriteLine("In the S/s area");
                File.WriteAllLines("names.txt", nameArray);
            }

            // to do: else if the option is a C or c then add a name to the array (if there's room)

                else if (userChoiceString=="C" || userChoiceString=="c")
            {
                bool contains = false;
                for (int i = 0; i < nameArray.Length; i++)
                {
                    if(nameArray[i] == "")
                    {
                        contains = true;
                        //get name update from user
                        Console.WriteLine("What name do you want to add?");
                        string newName = Console.ReadLine();
                        nameArray[i] = newName;
                        Console.WriteLine("The name has been added. ");
                    }
                }
                if(contains == false)
                {
                    Console.WriteLine("There is no room left in the array.");
                }
            }

            // to do: else if the option is an R or r then print the array

            else if (userChoiceString=="R" || userChoiceString=="r")
            {
                Console.WriteLine("In the R/r area");
                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine(nameArray[index]);
                }
            }

            // to do: else if the option is a U or u then update a name in the array (if it's there)
            else if (userChoiceString=="U" || userChoiceString=="u")
            {
                Console.WriteLine("In the U/u area");
                Console.WriteLine("What name do you want to update?");
                string whichName = Console.ReadLine();

                bool contains = false;
                for (int i = 0; i < nameArray.Length; i++)
                {
                    if(whichName == nameArray[i])
                    {
                        contains = true;
                        //get name update from user
                        Console.WriteLine("Please enter the updated name.");
                        string nameUpdate = Console.ReadLine();
                        nameArray[i] = nameUpdate;
                        Console.WriteLine("The name '" + whichName + "' has been updated to '" + nameUpdate + "'");
                    }

                }
                Console.WriteLine("This name is not in the list.");
            }

            // to do: else if the option is a D or d then delete the name in the array (if it's there)
            else if (userChoiceString=="D" || userChoiceString=="d")
            {
                Console.WriteLine("In the D/d area");
                Console.WriteLine("What name do you want to delete?");
                string nameToDelete = Console.ReadLine();

                bool contains = false;
                for (int i = 0; i < nameArray.Length; i++)
                {
                    if(nameToDelete == nameArray[i])
                    {
                        contains = true;
                        nameArray[i] = "";
                        Console.WriteLine("The name '" + nameToDelete + "' has been deleted from the array.");
                    }
                }

                Console.WriteLine("This name is not in the list.");

            }

            // to do: else if the option is a Q or q then quit the program

            else 
            {
                Console.WriteLine("Good-bye!");
            }

            //
            
   
      } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));
    } // ends main
  } // end class
} // ends namespace
