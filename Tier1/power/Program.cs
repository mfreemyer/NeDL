using System;

namespace power
{
  class Program
  {
    //method for obtaining valid integer
    static int GetValidInt(int valInt)
    {
     Console.WriteLine("Enter an integer greater than " + valInt);
     int val = Convert.ToInt32(Console.ReadLine());
          
      while(val <= valInt)
      {
       Console.WriteLine("The value entered must be greater than " + valInt);
       val = Convert.ToInt32(Console.ReadLine());
      }

      return val;
    }
    
    //method for calculating base to exponent power
      static double Power(double n, double e)
      {
        double powerResult = 0;
        //need explanation for how/why this works
        for (i = 1; i < e++)
        {
          powerResult *= n;
        }
        return powerResult;
      }
      

   //////////////////////////////
   static void Main(string[] args)
   {
    //obtain valid integer for base (call GetValidInt method)
    Console.WriteLine("Enter an integer for the base.");
    int baseNum = GetValidInt(0);
    Console.WriteLine(baseNum);

    //obtain valid integer for exponent (call GetValidInt method)
    Console.WriteLine("Enter an integer for the exponent.");
    int expoNum = GetValidInt(0);
    Console.WriteLine(expoNum);
   }

   //display power calc result
   {
     double resultOfCalc = Power(baseNum, expoNum);
     Console.WriteLine("{0} to the power of {1} is {2}", baseNum, expoNum, resultOfCalc);
   }
  }
}