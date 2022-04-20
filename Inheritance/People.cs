using System;

namespace Inheritance
{

    class People // base class (parent)
    {
        protected string FName;
        protected string LName;
        protected string Pronouns;
        protected string PType;

        // This is the default constructor when no values are being passed. 
        public People ()
        {
            FName = null;
            LName = null;
            Pronouns = null;
            PType = null;
        }

        // This is the constructor when values are passed.
        public People (string newFName, string newLName, string newPronouns, string newPType)
        {
            FName = newFName;
            LName = newLName;
            Pronouns = newPronouns;
            PType = newPType;
        }


        // Since FName, LName and Pronouns aren't defined as properties, I need to create the get and set methods for them.
        public string GetFName()
        {
            return FName;
        }

        public void SetFName (string newFName)
        {
            FName = newFName;
        }

       
        // get, set LName
        public string GetLName()
        {
            return LName;
        }

        public void SetLName (string newLName)
        {
            LName = newLName;
        }

        // get, set Pronouns
        public string GetPronouns()
        {
            return Pronouns;
        }

        public void SetPronouns (string newPronouns)
        {
            Pronouns = newPronouns;
        }

        // get, set PType
        public string GetPType()
        {
            return PType;
        }

        public virtual void SetPType (string newPType)
        {
            PType = newPType;
        }

        
        // ToString
        public override string ToString()
        {
            return FName + " " + LName + "  Preferred Pronouns: " + Pronouns + "  Type: " + PType;
        }


    }
}