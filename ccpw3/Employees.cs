using System;

namespace ccpw3
{

    class Employees // base class (parent)
    {
        private string fName;
        protected string lName;
        protected string emplType; // not working as char yet. come back and figure this out. 

        // default constructor when no values are being passed
        public Employees ()
        {
            fName = null;
            lName = null;
            emplType = null;
        }

        // constructor for when values are passed
        public Employees (string newFName, string newLName, string newEmplType) //update newEmplType back to char once figured out.
        {
            fName = newFName;
            lName = newLName;
            emplType = newEmplType;
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
        public string GetEmplType()
        {
            return emplType;
        }

        public void SetEmplType (string newEmplType)
        {
            emplType = newEmplType;
        }


        // ToString
        public override string ToString()
        {
            return fName + " " + lName + "  Employee Type: " + emplType;
        }



    }

}