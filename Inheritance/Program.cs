using System;

namespace Inheritance
{

    class Program
    {

        static void Main(string[] args)
        {

            //delare and instantiate the array of people
            People[] peopleArray=new People[150];

            //loop through each array element and instantiate an object for each person. 
            for (int index = 0; index < peopleArray.Length; index++)
            {
                peopleArray[index] = new People();
            }

            //delare and instantiate the array of students
            Students[] studentArray=new Students[50];

            //loop through each array element and instantiate an object for each student. 
            for (int index = 0; index < studentArray.Length; index++)
            {
                studentArray[index] = new Students();
            }


            //declare and instantiate the array of teachers
            Teachers[] teacherArray=new Teachers[25];

            //loop through each array element and instantiate an object for each teacher.
            for (int index = 0; index < teacherArray.Length; index ++)
            {
                teacherArray[index] = new Teachers();
            }




            //load some test data for People array
            peopleArray[0].SetFName("Maggie");
            peopleArray[0].SetLName("Freemyer-Ackerman");
            peopleArray[0].SetPronouns("She/Her");
            peopleArray[0].SetPType("Guardian");
            peopleArray[1].SetFName("Merida");
            peopleArray[1].SetLName("Ackerman");
            peopleArray[1].SetPronouns("She/Her");
            peopleArray[1].SetPType("Student");
            peopleArray[2].SetFName("Montserrat");
            peopleArray[2].SetLName("Recarte-Pacheco");
            peopleArray[2].SetPronouns("She/Her");
            peopleArray[2].SetPType("Teacher");
            peopleArray[3].SetFName("Jamie");
            peopleArray[3].SetLName("Pratts");
            peopleArray[3].SetPronouns("They/Them");
            peopleArray[4].SetFName("Chloe");
            peopleArray[4].SetLName("Tretsven");
            peopleArray[4].SetPronouns("She/Her");
            peopleArray[5].SetFName("Lloyd");
            peopleArray[5].SetLName("Ackerman");
            peopleArray[5].SetPronouns("He/Him");


            //load some test data for Student array
            studentArray[0].SetFName("Merida");
            studentArray[0].SetLName("Ackerman");
            studentArray[0].SetSGrade("2nd");
            studentArray[0].SetSteacher("Montse");
            studentArray[0].SetSActivities("Student Ambassador");
            studentArray[1].SetFName("Lloyd");
            studentArray[1].SetLName("Ackerman");
            studentArray[1].SetSGrade("Pre-K");
            studentArray[1].SetSteacher("Mrs. Davis");
            studentArray[1].SetSActivities("Science Club");
            studentArray[2].SetFName("Chloe");
            studentArray[2].SetLName("Tretsven");
            studentArray[2].SetSGrade("3rd");
            studentArray[2].SetSteacher("Mrs. Craig");
            studentArray[2].SetSActivities("Basketball Club");


            //load some test data for Student array
            teacherArray[0].SetFName("Montserrat");
            teacherArray[0].SetLName("Recarte-Pacheco");
            teacherArray[0].SetTGrade("2nd");
            teacherArray[0].SetTType("Classroom");
            teacherArray[0].SetTTenured("Yes");
            teacherArray[1].SetFName("Melissa");
            teacherArray[1].SetLName("Craig");
            teacherArray[1].SetTGrade("K-3");
            teacherArray[1].SetTType("EL");
            teacherArray[1].SetTTenured("Yes");
            teacherArray[2].SetFName("Jamie");
            teacherArray[2].SetLName("Pratts");
            teacherArray[2].SetTGrade("3rd");
            teacherArray[2].SetTType("Classroom");
            teacherArray[2].SetTTenured("Yes");




            
            //header people array
            Console.WriteLine();
            Console.WriteLine("*** People ***");

            
            //print each person to test the property gets and the toString
            for (int index = 0; index < peopleArray.Length; index++)
            {
                if(!(((peopleArray[index]).GetFName())==null))
                    Console.WriteLine(peopleArray[index]);
            }

            //header students array
            Console.WriteLine();
            Console.WriteLine("*** Students ***");

            //print each student to test the property gets and the toString
            for (int index = 0; index < studentArray.Length; index++)
            {
                if(!(((studentArray[index]).GetFName())==null))
                    Console.WriteLine(studentArray[index]);
            }


            //header teachers array
            Console.WriteLine();
            Console.WriteLine("*** Teachers ***");

            //print each teacher to test the property gets and the toString
            for (int index = 0; index < teacherArray.Length; index++)
            {
                if(!(((teacherArray[index]).GetFName())==null))
                    Console.WriteLine(teacherArray[index]);
            }

        }
    }
}