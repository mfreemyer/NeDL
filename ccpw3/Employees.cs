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


        // ToString
        public override string ToString()
        {
            return fName + " " + lName + "  Employee Type: " + emplType;
        }



    }

}