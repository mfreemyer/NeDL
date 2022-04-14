using System;

namespace loops
{
  class Program
    {

    static int MyMin(int x,int y)
    {
      if (x < y) 
      {
        return x;
      }
      else return y;
    }

    static int MyMax(int x,int y)
    {
      if (x > y) 
      {
        return x;
      }
      else return y;
    }

    static int GetValidInt(int lowVal, int highVal) 
    {
      Console.WriteLine("Enter an integer between " + lowVal + " and " + highVal);
      //read the int here 
      int val = Convert.ToInt32(Console.ReadLine());
      
      while(val < lowVal || val > highVal)
      {
      Console.WriteLine("The value entered must be between " + lowVal + " and " + highVal + ".");
      val = Convert.ToInt32(Console.ReadLine());
      }

      return val;
    }

   static void Main(string[] args)
    {
      //Get valid number of quizzes from user  
      Console.WriteLine("How many quiz scores do you have to enter?");
      int numQuizzes =  GetValidInt(1,1000);
      

    //initialize minimum quiz
      int minQuiz = 101;
    //initialize maximum quiz
      int maxQuiz = -1;
    //initialize average quiz
      double avgQuiz = 0;

     //For each quiz
      for (int newQuiz = 0; newQuiz < numQuizzes; newQuiz++)
      {

      //Get a valid quiz score
        
          Console.WriteLine("Enter Quiz Score: " + (newQuiz+1));
          int quizScore =  GetValidInt(0,100);

          
      //check to see if score is minimum
      //check to see if score is maximum
      //find average score
         minQuiz = MyMin (quizScore, minQuiz);
         maxQuiz = MyMax (quizScore, maxQuiz);

         avgQuiz = avgQuiz+quizScore;
      

      }
          Console.WriteLine("The minimum score is " + minQuiz);
          Console.WriteLine("The maximum score is " + maxQuiz);
          Console.WriteLine("The average score is " + avgQuiz/numQuizzes);

    }
  }
}

