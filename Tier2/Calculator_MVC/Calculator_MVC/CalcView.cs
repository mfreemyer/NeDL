using System;

namespace Calculator_MVC
{
    class CalcView
    {
        // this is the CalcView class. its purpose is to gather the input and display the output. 
        // its just reading and writing to the user
        // variables are class-level fields, so the controller can have access to the fields through properties.


        //private fields
        private double Num1;
        private double Num2;
        private string Op;
        private double Result;
        
        // constructor
        public CalcView()
        {
            Num1 = 0;
            Num2 = 0;
            Op = "";
            Result = 0;
            GetValues();

        }

        

        


    }
}