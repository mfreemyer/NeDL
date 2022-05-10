using System;

namespace helloworld
{
  class Program
  {
   static void Main(string[] args)
   {
    Console.WriteLine("Number of feet:");
    int numFeet = Convert.ToInt32(Console.ReadLine());

    while (numFeet < 0){
      Console.WriteLine("Please enter a number of 0 or greater.");
      numFeet = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("There are " + numFeet * 12 + " inches");
      
     

  }
 }
}