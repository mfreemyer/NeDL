using System;

namespace Collection
{

    class Pokemon
    {

        // Three pieces of data are being stored for each object. 

        
        // This is the instance variable so it must be declared. It's private so only methods of the object can access it.
        private string PName; // Pokemon name

        // This is an automatic property variable. 
        // Why does it yell at me when I try to create the get and set methods here? 
        public string PType // property 
            { get; set; }

        // This is an automatic property variable. 
        public double PWeight; // proprery
            

        
        // This is the default constructor when no values are being passed.
        public Pokemon ()
        {
            PName = null;
            PType = null;
            PWeight = -1;
        }

        // This is the constructor when values are passed.
        public Pokemon (string newPName, string newPType, double newPWeight)
        {
            PName = newPName;
            PType = newPType;
            PWeight = newPWeight;
        }


        // Since PName is not defined as a prperty, I need to create the get and set methods for it.
        public string GetName()
        {
            return PName;
        }

        public void SetName (string newPName)
        {
            PName = newPName;
        }


        // This overrides ToString so an object can be printed out with the WriteLine.
        // ** I need to look into this. Don't understand this part. 
        public override string ToString()
        {
            return "Pokemon Name: " + PName + "  | Type: " + PType + "  | Weight: " + PWeight + " lbs.";
        }
        

        



        

    }
}