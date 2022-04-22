using System;

namespace ccpw3
{

    class Employees // base class (parent)
    {
        private string fName;
        private string lName;
        private char emplType; 
        private float bonus;




        // default constructor when no values are being passed
        public Employees ()
        {
            fName = null;
            lName = null;
            emplType = '?';
            bonus = 0.00F;
        }

        // constructor for when values are passed
        public Employees (string newFName, string newLName, char newEmplType, float newBonus) //update newEmplType back to char once figured out.
        {
            fName = newFName;
            lName = newLName;
            emplType = newEmplType;
            bonus = newBonus;
        }

        // since fName, lName and emplType aren't defined as properties, create the get and set methods for them.
        public string GetFName()
        {
            return fName;
        }

        public void SetFName (string newFName)
        {
            fName = newFName;
        }


        // lName get, set
        public string GetLName()
        {
            return lName;
        }

        public void SetLName (string newLName)
        {
            lName = newLName;
        }


        // emplType get, set
        public char GetEmplType()
        {
            return emplType;
        }

        public void SetEmplType (char newEmplType)
        {
            emplType = newEmplType;
        }


        // bonus get, set
        public float GetBonus()
        {
            return bonus;
        }

        // polymorphism attempt
        public virtual void SetBonus ()
        {
            Console.WriteLine(0);
        }


        // ToString
        public override string ToString()
        {
            return fName + " " + lName + "  Employee Type: " + emplType; 
        }


    }

}