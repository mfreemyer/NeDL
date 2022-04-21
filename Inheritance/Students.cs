using System;

namespace Inheritance
{
/* sGrade 
sTeacher
sActivities */

    class Students : People // derived class (child)
    {
        protected string sGrade;
        protected string sTeacher;
        protected string sActivities;

        // This is the default constructor when no values are being passed. 
        public Students ()
        {
            FName = null;
            LName = null;
            //PType = "Student";
            sGrade = null;
            sTeacher = null;
            sActivities = null;
        }

        // This is the constructor when values are passed.
        public Students (string newFName, string newLName, string newPType, 
        string newSGrade, string newSTeacher, string newSActivities)
        {
            FName = newFName;
            LName = newLName;
            //PType = newPType;
            sGrade = newSGrade;
            sTeacher = newSTeacher;
            sActivities = newSActivities;

        }

        // polymorphism attempt -- not working. keep working on this. 
        public string GetPType()
        {return PType;}

        public override void SetPType (string newPType)
        {PType = "Student";}


        // Since sGrade, sTeacher and sActivities aren't defined as properties, I need to create the get and set methods for them.
        public string GetSGrade()
        {return sGrade;}

        public void SetSGrade (string newSGrade)
        {sGrade = newSGrade;}

       
        // get, set sTeacher
        public string GetSTeacher()
        {return sTeacher;}

        public void SetSteacher (string newSTeacher)
        {sTeacher = newSTeacher;}

        // get, set sActivities
        public string GetSActivities()
        {return sActivities;}

        public void SetSActivities (string newSActivities)
        {sActivities = newSActivities;}


        
        // ToString
        public override string ToString()
        {
            return FName + " " + LName + "  Person Type: " + PType +
            "   Grade Level: " + sGrade + "  Current Teacher: " + sTeacher + "   Extra Activites/Clubs: " + sActivities;
        }


    }
}