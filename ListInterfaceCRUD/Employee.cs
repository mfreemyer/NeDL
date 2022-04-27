using System;

namespace ListInterfaceCRUD
{

    class Employee : IRate
    {
        public string fName // property
            { get; set; }
        
        public string lName // property
            { get; set; }

        public string emplType // property
            { get; set; }

        
        // default constructor for when no values are passed
        public Employee()
        {
            fName = "";
            lName = "";
            emplType = "";
        }

        // constructor for when values are passed
        public Employee(string newFName, string newLName, string newEmplType)
        {
            fName = newFName;
            lName = newLName;
            emplType = newEmplType;
        }

        public override string ToString()
        {
            return "Employee: " + fName + " " + lName + "  |  Type: " + emplType;
        }

        public virtual void SetRate(double newRate)
        {

        }

    }
}