using System;

namespace Calculator_MVC
{
    class CalcModel
    {
        private double num1;   // first private attribute/class variable accessible only through methods
        private double num2;   // second private attribute/class variable accessible only through methods

        public CalcModel()    // default constructor method that initializes both values to 0;
        {
            num1 = 0;
            num2 = 0;
        }
        public double Number1  // property for num1 to declare the accessor and mutator
        {
            get { return num1; }
            set { num1 = value; }
        }
        public double Number2  // property for num2 to declare the accessor and mutator
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double DoOperation(string op)  // public method to do an operation
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // check for a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
