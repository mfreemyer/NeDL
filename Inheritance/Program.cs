using System;

namespace Inheritance
{

    class Program
    {

        static void Main(string[] args)
        {

            //delare and instantiate the array of people
            People[] peopleArray=new People[200];

            //loop through each array element and instantiate an object for each. 
            for (int index = 0; index < peopleArray.Length; index++)
            {
                peopleArray[index] = new People();
            }

            //load some test data
            peopleArray[0].SetFName("Maggie");
            peopleArray[0].SetLName("Freemyer-Ackerman");
            peopleArray[0].SetPronouns("She/Her");
            peopleArray[0].SetPType("Parent");
            peopleArray[1].SetFName("Merida");
            peopleArray[1].SetLName("Ackerman");
            peopleArray[1].SetPronouns("She/Her");
            peopleArray[1].SetPType("Student");
            peopleArray[2].SetFName("Montserrat");
            peopleArray[2].SetLName("Recarte-Pacheco");
            peopleArray[2].SetPronouns("She/Her");
            peopleArray[2].SetPType("Teacher");




            


            
            //print each person to test the property gets and the toString
            for (int index = 0; index < peopleArray.Length; index++)
            {
                if(!(((peopleArray[index]).GetFName())==null))
                    Console.WriteLine(peopleArray[index]);
            }

        }
    }
}