using System;

namespace CCPW5
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello NeDL!");
            // create lists and list objects
            List<Membership> memberList = new List<Membership>(); // this list needs to be deleted after testing Membership class (for abstraction)


            // hard code the test data into the lists
            memberList.Add(new Membership (123, "123@gmail.com", 'R', 60, 162.73));
            memberList.Add(new Membership (100, "100@gmail.com", 'E', 120, 417.56));
            memberList.Add(new Membership (200, "200@gmail.com", 'B', 90, 6248.01));
            memberList.Add(new Membership (300, "300@gmail.com", 'N', 50, 2062.93));

            // print the lists
            Console.WriteLine(); // for user-friendliness in terminal
            foreach (Membership aMembership in memberList)
            { Console.WriteLine(aMembership); }





        }
    }
}