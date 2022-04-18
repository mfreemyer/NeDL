using System;
using System.IO;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables and arrays
            string[] foodArray = new string[25];
            string[] numberArray = new string[25];
            string[] foodNumArray = new string[50];
            string food = "";
            string nmbr = ""; 
            int index = 0;

            using (StreamReader sr = File.OpenText("food.txt"))
            {
                while ((food = sr.ReadLine()) !=null)
                {
                    Console.WriteLine(food + "      * prints from foodArray");
                    foodArray[index] = food;
                    nmbr = sr.ReadLine();
                    numberArray[index] = nmbr;
                    Console.WriteLine(nmbr + "            * prints from numberArray");
                    index = index + 1;
                }
            }

            

            foreach (var item in foodArray) 
            {
                Console.WriteLine(item);
            }

            foreach (var item in numberArray) 
            {
                Console.WriteLine(item);
            }


            for (index = 0; index < foodArray.Length; index++)
            {
                Console.WriteLine(foodArray[index]);
                Console.WriteLine(numberArray[index]);
            }

            //use sr.WriteLine? to save to file
            using (StreamWriter sw = File.WriteAllText("food.txt"))
            {
                for (index = 0; index < foodArray.Length; index++)
            {
                sw.WriteLine(foodArray[index]);
                sw.WriteLine(numberArray[index]);
            }
            

            }
            






            //attempt to merge the arrays




        }
    }
}
