using System;

namespace OOPPractice
{

    class Program
    {

        static void Main(string[] args)
        {
            //declare and instantiate the array of Restaurant objects
            Restaurant[] restaurantArray = new Restaurant[25];
            Restaurant newRes = new Restaurant();
            Console.WriteLine(newRes.RName);
        }
    }
}