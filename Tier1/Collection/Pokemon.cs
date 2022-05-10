using System;

namespace Collection
{

    class Pokemon
    {

        // Three pieces of data are being stored for each object. 
        // PName is the Pokemon name. To show the difference in how values can be stored, PName is an instance variable.
        // PType is the pokemon type and PWeight is the weight.  
        // To show the difference in how values can be stored, PType and PWeight are automatic properties

        
        // This is the instance variable so it must be declared. It's private so only methods of the object can access it.
        private string PName; // Pokemon name

        // This is an automatic property variable. 
        // NEED TO BETTER UNDERSTAND WHAT'S HAPPENING HERE WITH THE GET AND SET.
        // are set and get pre-created methods? if so, why aren't they capitalized?
        public string PType // property 
            { set; get; }

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


        // Since PName is not defined as a property, I need to create the get and set methods for it.
        public string GetName()
        {
            return PName;
        }

        public void SetName (string newPName)
        {
            PName = newPName;
        }


        // This overrides ToString so an object can be printed out with the WriteLine.
        // NEED TO GET A BETTER UNDERSTANDING OF THIS. IS THIS A PRECREATED METHOD?
        public override string ToString()
        {
            return "Pokemon Name: " + PName + "  | Type: " + PType + "  | Weight: " + PWeight + " lbs.";
        }
        

        



        

    }
}