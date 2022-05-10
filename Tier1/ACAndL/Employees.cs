using System;

namespace ACAndL
{

    abstract class Employees
    {
        public string fName  // property
            { get; set; }
        
        public string lName // property
            { get; set; }
        
        public string emplType // property
            { get; set; }
        
        public Employees() // default constructor
        {
            fName = "";
            lName = "";
            emplType = "";
        }

        public Employees(string newFName, string newLName, string newEmplType) // constructor for when values are passed
        {
            fName = newFName;
            lName = newLName;
            emplType = newEmplType;
        }

        
        public abstract double GetBonus(); // this is the abstract method that all children MUST implement

        public override string ToString()
        {
            return "Employee: " + fName + " " + lName + "  |  Type: " + emplType;
        }

    }
}