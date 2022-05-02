using System;

namespace CCPW5
// *** the regular and executive memberships will implement a special offer method from an interface.  
        // the implementation for a regular membership will simply return 25% of the annual membership cost.
        // the implementation for the executive membership will return 50% of the annual membership cost.
{

    interface ISpecialOffer
    {

        // interface method
        double SpecialOffer();

    }
}