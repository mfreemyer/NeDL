using System;
using System.IO;

namespace ccpw2
{
  class Program
  {
    static void Main(string[] args)
    {

      // declare variables
      bool userChoice;
      string userChoiceString;
      string[,] resRevArray = new string[25,2];

      // repeat main looop
      do
      {

        //get a valid input
        do
        {
            //Menu of options
            Console.WriteLine("WHAT WOULD YOU LIKE TO DO?");
            Console.WriteLine("O: Open the reviews file");
            Console.WriteLine("S: Save changes");
            Console.WriteLine("C: Create a new restaurant rating");
            Console.WriteLine("R: Read/print a list of restaurants and their ratings");
            Console.WriteLine("U: Update a restaurant and/or their rating");
            Console.WriteLine("D: Delete a restaurant");
            Console.WriteLine("Q: Quit the program");

            // get valid option from user
                        
                userChoiceString = Console.ReadLine();
                userChoice = (userChoiceString == "O" || userChoiceString == "o" ||
                              userChoiceString == "S" || userChoiceString == "s" ||
                              userChoiceString == "C" || userChoiceString == "c" ||
                              userChoiceString == "R" || userChoiceString == "r" ||
                              userChoiceString == "U" || userChoiceString == "u" ||
                              userChoiceString == "D" || userChoiceString == "d" ||
                              userChoiceString == "Q" || userChoiceString == "q");

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option from the list.");
                }
            
        } while (!userChoice);

            //TO DO: O -- Open the user's list of restaurants
            if (userChoiceString=="O" || userChoiceString=="o")
            {
                int index = 0; //index for my array
                using (StreamReader sr = File.OpenText("RestaurantReviews"))
                {
                    string s = "";
                    Console.WriteLine("Restaurant Reviews: ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        resRevArray[index, index] = s; //need to figure out how to properly do this since double array
                        index = index + 1;
                    }
                }
            }

            //TO DO: S -- Save the user's list of restaurants (no blank lines in data file)

            //TO DO: C -- Add a restaurant and rating (make sure user provides both, also handle "file full" case)

            //TO DO: R -- Print a list of all the restaurants and their ratings (no blank lines, handle "nothing in list" case)

            //to do: U -- (optional) Update the rating for a restaurant

            //to do: D -- (optional) Delete a restaurant

            //TO DO: Q -- Quit the program

      } while (!(userChoiceString=="Q") && !(userChoiceString=="q")); //ends 'repeat main loop'

    } // ends main
  } // end class
} // ends namespace

