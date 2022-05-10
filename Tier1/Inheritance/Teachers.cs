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
            FName = null;
            LName = null;
            PType = "Teacher";
            tGrade = null;
            tType = null;
            tTenured = null;
        }

        // This is the constructor when values are passed.
        public Teachers (string newFName, string newLName, string newPType,
            string newTGrade, string newTType, string newTTenured)
        {
            FName = newFName;
            LName = newLName;
            PType = newPType;
            tGrade = newTGrade;
            tType = newTType;
            tTenured = newTTenured;

        }

        // create get and set methods since variables are not defined as properites

        //PType
        public string GetPType()
        {
            return PType;
        }

        //PType -- using polymorphism? 
        public override void SetPType (string newPType)
        {
            PType = newPType;
        }

        //tGrade
        public string GetTGrade()
        {
            return tGrade;
        }

        public void SetTGrade (string newTGrade)
        {
            tGrade = newTGrade;
        }

        //tType
        public string GetTType()
        {
            return tType;
        }

        public void SetTType (string newTType)
        {
            tType = newTType;
        }


        //tTenured
        public string GetTTenured()
        {
            return tTenured;
        }

        public void SetTTenured (string newTTenured)
        {
            tTenured = newTTenured;
        }


        //ToString
        public override string ToString()
        {
            return FName + " " + LName + "  Person Type: " + PType +
            "   Grade Teaching: " + tGrade + "  Teacher Type: " + tType + "   Tenured? " + tTenured;

        }

    }
}