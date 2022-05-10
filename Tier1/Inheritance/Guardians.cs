using System;

namespace Inheritance
{
/* gNumKids (number of kids at the school), 
gKidNames, 
gRegVol (registered volunteer) */

    class Guardians : People // derived class (child)
    {
        protected string gNumKids;
        protected string gKidNames;
        protected string gRegVol;

        // This is the default constructor when no values are being passed. 
        public Guardians ()
        {
            gNumKids = "0";
            gKidNames = "none entered";
            gRegVol = "No";
        }

        // This is the constructor when values are passed.
        public Guardians (string newGNumKids, string newGKidNames, string newGRegVol)
        {
            gNumKids = newGNumKids;
            gKidNames = newGKidNames;
            gRegVol = newGRegVol;

        }

    }

}