using System;

namespace ccpw1
{
  class Program
  {
    static void Main(string[] args)
    {
      //get number of students from user
      Console.WriteLine("Please enter the number of students.");   
      int numStudents = Convert.ToInt32(Console.ReadLine());
      
      //ensure number is valid (greater than 0)
      while (numStudents <= 0)
      {
        Console.WriteLine("The number must be greater than 0.");
        numStudents = Convert.ToInt32(Console.ReadLine());
      }
      
      //initialize calc variables
      double hAvg = 0;
      int hTotal = 0; 
      double qAvg = 0;
      int qTotal = 0;
      double eAvg = 0;
      int eTotal = 0;
      double fAvg = 0;
      string fGrade;

      //create for loop for obtaining student information
      for (int newStudent = 0; newStudent < numStudents; newStudent++)
      {
        //get each student's name
        Console.WriteLine("Student Name ");
        string studentName = Console.ReadLine();

        //get 5 homework grades and their average
        hTotal = 0; //initialize the homework total to 0 again (so that it restarts for each student)

        for (int newHmwrk = 0; newHmwrk < 5; newHmwrk++) 
        {
          Console.WriteLine("Enter " + studentName + "'s homework score " + (newHmwrk+1));
          int hGrade = Convert.ToInt32(Console.ReadLine());

          //ensure homework grades are valid (between 0 and 100 inclusively)
          while (hGrade < 0 || hGrade > 100)
          {
            Console.WriteLine("The number must be between 0 and 100. Please try again.");
            hGrade = Convert.ToInt32(Console.ReadLine());
          }

          hTotal = hTotal+hGrade; //add the new homework grade into the total
        }
        hAvg = hTotal / 5.0;
    
        //get 3 quiz grades 
        qTotal = 0; //initialize the quiz total to 0
        for (int newQuiz = 0; newQuiz < 3; newQuiz++) 
        {
          Console.WriteLine("Enter " + studentName + "'s quiz score " + (newQuiz+1));
          int qGrade = Convert.ToInt32(Console.ReadLine());

          //ensure quiz grades are valid (between 0 and 100 inclusively)
          while (qGrade < 0 || qGrade > 100)
          {
            Console.WriteLine("The number must be between 0 and 100. Please try again.");
            qGrade = Convert.ToInt32(Console.ReadLine());
          }

          qTotal = qTotal+qGrade; //add the new quiz grade into the total
        }
        qAvg = qTotal / 3.0;

        //get 2 exam grades 
        eTotal = 0; //initialize the exam total to 0 (so that it restarts for each student)
        for (int newExam = 0; newExam < 2; newExam++) 
        {
          Console.WriteLine("Enter " + studentName + "'s exam score " + (newExam+1));
          int eGrade = Convert.ToInt32(Console.ReadLine());

          //ensure exam grades are valid (between 0 and 100 inclusively)
          while (eGrade < 0 || eGrade > 100)
          {
            Console.WriteLine("The number must be between 0 and 100. Please try again.");
            eGrade = Convert.ToInt32(Console.ReadLine());
          }

          eTotal = eTotal+eGrade; //add the new exam grade into the total
        }
        eAvg = eTotal / 2.0;

        //calculate final avg (fAvg) for each student
        double whAvg = hAvg*0.5;
        double wqAvg = qAvg*0.3;
        double weAvg = eAvg*0.2;
        fAvg = whAvg+wqAvg+weAvg;
        
        //calculate final grade (fGrade) for each student
        if (fAvg>=90)
        {
          fGrade = "A";
        }
        else if (fAvg>=80)
        {
          fGrade = "B";
        }
        else if (fAvg>=70)
        {
          fGrade = "C";
        }
        else if (fAvg>=60)
        {
          fGrade = "D";
        }
        else 
        {
          fGrade = "F";
        }

        //display student's name and grade information
        Console.WriteLine("Grade Information for " + studentName + ": ");
        Console.WriteLine("Homework average is " + hAvg);
        Console.WriteLine("Quiz average is " + qAvg);
        Console.WriteLine("Exam average is " + eAvg);
        Console.WriteLine("Finale grade average is " + fAvg);
        Console.WriteLine("Final grade is " + fGrade);

      }
    } 
  }
}


