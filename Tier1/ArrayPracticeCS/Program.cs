using System;
using System.IO;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //establish array, get words from user
            string[] wordArray = new string[10];
            //iterate through the array
            for(int newWordInt = 0;newWordInt<10;newWordInt++)
            {
                //displays newWord value + 1 (so that the count starts at 1 for user (instead of 0))
                Console.WriteLine("Enter word " + (newWordInt+1) + ": ");
                string word = Console.ReadLine();
                wordArray[newWordInt] = word;
            }
            //output the number obtained from user
            for(int newWordInt = 0;newWordInt<10;newWordInt++)
            {
                Console.WriteLine("the word " + newWordInt+": " + wordArray[newWordInt]);
            }

            // print each array value 
            foreach (string word in wordArray)
            {
                Console.WriteLine(word);
            }

            


            //=====================
            //
            /* //establish array, get words from user
            string[] wordArray = new string[10];
            //iterate through the array
            for(int newWordInt = 0;newWordInt<10;newWordInt++)
            {
                //displays newWord value + 1 (so that the count starts at 1 for user (instead of 0))
                Console.WriteLine("Enter word " + (newWordInt+1) + ": ");
                string word = Console.ReadLine();
                wordArray[newWordInt] = word;
            }
            //output the number obtained from user
            for(int newWordInt = 0;newWordInt<10;newWordInt++)
            {
                Console.WriteLine("the word " + newWordInt+": " + wordArray[newWordInt]);
            } */

            //=====================


            
            
            //ask how many many numbers user wants to enter/how big the array should be
            Console.WriteLine("How many numbers do you want to add?");
            int numEntries = Convert.ToInt32(Console.ReadLine());
            
            //establish array, get numbers from user
            int[] myNumbers = new int[numEntries];
            /* int[] myNumbers = new int[10]; */
            for(int newNum = 0;newNum<numEntries;newNum++)
            {
                //displays newNum + 1 (so that the count starts at 1 for user (instead of 0))
                Console.WriteLine("Enter number " + (newNum+1) + ": ");
                int cnvrtNewNum = Convert.ToInt32(Console.ReadLine());
                myNumbers[newNum] = cnvrtNewNum;
            }
            //output the number obtained from user
            for(int newNum = 0;newNum<numEntries;newNum++)
            {
                Console.WriteLine("the number " + newNum+": " + myNumbers[newNum]);
            }

            //calculate and display max
            int max = myNumbers[0];
            for(int newNum=0;newNum<myNumbers.Length;newNum++)
            {
            if(myNumbers[newNum]>max)
            {
                max = myNumbers[newNum];
            }
            }
            Console.WriteLine("The max in this array is " + max);

            //calculate and display min
            int min = myNumbers[0];
            for(int newNum=0;newNum<myNumbers.Length;newNum++)
            {
                if(myNumbers[newNum]<min)
                {
                    min = myNumbers[newNum];
                }
                }
            Console.WriteLine("The min in this array is " + min);

            //calculate and display sum
            int numSum = 0;
            for (int newNum=0;newNum<myNumbers.Length;newNum++)
            {
                numSum += myNumbers[newNum];
            }
            Console.WriteLine("The sum in this array is " + numSum);
            
            //calculate and display average (no for loop needed since numbers already obtained from sum calc)
            double avg = numSum/myNumbers.Length;
            Console.WriteLine("The average of the array is " + avg);

            //count numbers above average (got this from Derek. determines above avg entries, but doesn't display corrrectly yet)
            int abvAvg = 0;
            for (int i = 0; i < myNumbers.Length; i++)
            {
                if(myNumbers[i]>avg)
                {
                    Console.WriteLine(i);
                    abvAvg = myNumbers[i];
                }
            }
            Console.WriteLine("The above average numbers are " + abvAvg);

            //count numbers below average

        } //main
    } //end program
} //end namespace
