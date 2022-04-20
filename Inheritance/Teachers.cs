using System;

namespace Inheritance
{
/* tGrade
tType
tTenured */

    class Teachers : People // derived class (child)
    {
        protected string tGrade;
        protected string tType;
        protected string tTenured;

        // This is the default constructor when no values are being passed. 
        public Teachers ()
        {
            tGrade = "All";
            tType = "Homeroom";
            tTenured = "No";
        }

        // This is the constructor when values are passed.
        public Teachers (string newTGrade, string newTType, string newTTenured)
        {
            tGrade = newTGrade;
            tType = newTType;
            tTenured = newTTenured;

        }

    }
}