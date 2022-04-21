using System;

namespace ccpw3
{

    class Program
    {

        static void Main(string[] args)
        {
            Employees  objFName = new Employees();

            objFName.SetFName("Maggie");

            Console.WriteLine("First Name: " + objFName.GetFName());

        }
    }
}