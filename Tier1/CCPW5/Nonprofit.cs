using System;

namespace CCPW5
// *** the non-profit membership has a cash-back percentage and also a field to indicate if it is a 
        // military or educational organization and if so doubles the cash-back percentage
{

    class Nonprofit : Membership
    {
        // define properties
        public double nCBP // Non-profit Cash-Back Percentage
            { get; set; }
        public char milOrEd // Y for yes, N for no 
            { get; set; }

        // default constructor
        public Nonprofit() : base()
        {
            nCBP = 0.03;
            milOrEd = '?';
        }

        // constructor for when values are passed 
        public Nonprofit(int newMemberID, string newEmail, char newMemberType, double newAnnualCost, double newCurrentPFM, double newNCBP, char newMilOrEd) : base (newMemberID, newEmail, newMemberType, newAnnualCost, newCurrentPFM)
        {
            nCBP = newNCBP;
            milOrEd = newMilOrEd;
        }

        // methods
        public override double ApplyCBR() // print to console, then zero out the balance. 
        {
            if (milOrEd == 'Y' || milOrEd == 'y')
            {
                Console.WriteLine("Cash-back reward request for membership " + memberID + " in the amount of " + String.Format("${0:n}",((currentPFM * (nCBP * 2)))) + " has been made. " );
                Console.Write("The Purchases For Month (PFM) balance has been updated from " + String.Format("${0:n}",(currentPFM)));
                currentPFM = 0.0;
                Console.WriteLine(" to " + String.Format("${0:n}",(currentPFM)) + ".");
                return currentPFM;
            }
            else
            {
                Console.WriteLine("Cash-back reward request for membership " + memberID + " in the amount of " + String.Format("${0:n}",((currentPFM * nCBP))) + " has been made. " );
                Console.Write("The Purchases For Month (PFM) balance has been updated from " + String.Format("${0:n}",(currentPFM)));
                currentPFM = 0.0;
                Console.WriteLine(" to " + String.Format("${0:n}",(currentPFM)) + ".");
                return currentPFM;
            }
        }

        
        
        // to string
        public override string ToString()
        {
            return base.ToString() + "  | CBR *: " + nCBP * 100 + " %" + "  | Military or School: " + milOrEd;
        }


    }
}