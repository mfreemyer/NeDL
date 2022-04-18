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
      string[] nameArray = new string[25];
      string[] rateArray = new string[25];
      string[] nameRateArray = new string[50];

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
                using (StreamReader sr = File.OpenText("RestaurantReviews.txt"))
                {
                    string rName = "";
                    string rRate = "";
                    Console.WriteLine("Restaurant Reviews: ");
                    while ((rName = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(rName);
                        nameArray[index] = rName; 
                        rRate = sr.ReadLine();
                        Console.WriteLine(rRate);
                        rateArray[index] = rRate;
                        index = index + 1;
                    }
                }
            }

            //TO DO: S -- Save the user's list of restaurants (no blank lines in data file)
            //NOT SAVING CORRECTLY -- overwrites nameArray with rateArray. 
            //figure out how not to fill in a bunch of blank lines
            else if (userChoiceString=="S" || userChoiceString=="s")
            {
              int index = 0;
              using (StreamWriter sw = new StreamWriter("RestaurantReviews.txt"))
              {
                  //string rName = "";
                  //string rRate = "";
                  for (index = 0; index < nameArray.Length; index++)
                  {
                      sw.WriteLine(nameArray[index]);
                      sw.WriteLine(rateArray[index]);
                  }
              }
              Console.WriteLine("Your updates have been saved.");
            }

            //TO DO: C -- Add a restaurant and rating (make sure user provides both, also handle "file full" case)
            //do validation for rating, 
            else if (userChoiceString=="C" || userChoiceString=="c")
            {
              bool contains = false;
              for (int i = 0; i < nameArray.Length; i++)
              {
                if((nameArray[i] == null) && (contains == false))
                {
                  contains = true;
                  //get new name from user
                  Console.WriteLine("Please enter the name of the restaurant you want to add.");
                  string newName = Console.ReadLine();
                  nameArray[i] = newName;
                  //get new rate from user
                  Console.WriteLine("Please enter a rating between 1 and 5.");
                  string newRating = Console.ReadLine();
                  rateArray[i] = newRating;
                  Console.WriteLine("The restaurant review has been added.");
                }

              }

              if(contains == false)
              {
                Console.WriteLine("The list is full.");
              }

            }

            //TO DO: R -- Read/Print a list of all the restaurants and their ratings (no blank lines, handle "nothing in list" case)
            else if (userChoiceString=="R" || userChoiceString=="r")
            {
              for (int index = 0; index < nameArray.Length; index++)
              {
                Console.WriteLine(nameArray[index]);
                Console.WriteLine(rateArray[index]);
              }

            }

            //to do: U -- (optional) Update the rating for a restaurant

            //to do: D -- (optional) Delete a restaurant

            //TO DO: Q -- Quit the program

      } while (!(userChoiceString=="Q") && !(userChoiceString=="q")); //ends 'repeat main loop'

    } // ends main
  } // end class
} // ends namespace

