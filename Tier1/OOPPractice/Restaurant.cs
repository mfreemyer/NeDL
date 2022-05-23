using System;

namespace OOPPractice
{

    class Restaurant
    {
        // Two pieces of data are being stored for each object.
        // RName is the restaurant name
        // RName will be an instance variable to show the difference in how values can be stored. 
        // RRating is the restaurant rating
        // RRating will be an automatic property
        
        // This is the instance variable, so it must be declared. It's private, so only methods of the object can access it. 
        private string RName; 
        
        // This is the automatic property variable. The get and set methods are being created too.
        public int RRating
            {get; set;}


        // This is the default constructor when no values are being passed. 
        public Restaurant ()
        {
            RName = "";
        }
        

    }
}