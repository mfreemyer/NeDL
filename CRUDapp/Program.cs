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
            }

            // to do: else if the option is a C or c then add a name to the array (if there's room)

                else if (userChoiceString=="C" || userChoiceString=="c")
            {
                Console.WriteLine("In the C/c area");
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
            }

            // to do: else if the option is a D or d then delete the name in the array (if it's there)
            ////prompt user for name and then overwrite it with blank (if i'm understanding correctly)
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
                        Console.WriteLine("The name -- " + nameToDelete + " -- has been deleted from the array.");
                        Console.WriteLine("The new array is as follows: ");
                    }
                }
                if(contains == true)
                {
                    //printing array here to test if name was deleted from array
                    for (int index =0; index < 10; index++)
                    {
                        Console.WriteLine(nameArray[index]);
                    }
    
                }
                else
                {
                    Console.WriteLine("This name is not in the list.");
                }
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

