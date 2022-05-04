using System;

namespace CCPW5
{

    abstract class Membership
    {
        // define properties
        public int memberID
        { get; set; }
        public string email
        { get; set; }
        public char memberType
        { get; set; }
        public double annualCost
        { get; set; }
        public double currentPFM // current amount of Purchases For the Month
        { get; set; }

        // default constructor
        public Membership()
        {
            memberID = 0;
            email = "";
            memberType = '?';
            annualCost = 0.0;
            currentPFM = 0.0;
        }

        // constructor for when values are passed
        public Membership(int newMemberID, string newEmail, char newMemberType, double newAnnualCost, double newCurrentPFM)
        {
            memberID = newMemberID;
            email = newEmail;
            memberType = newMemberType;
            annualCost = newAnnualCost;
            currentPFM = newCurrentPFM;
        }


        // methods*************************************************************
        // Purchase method
            // *** A purchase will include the membership id and the amount of the purchase (which must be > 0). 
                    // All four accounts handle a purchase in the same way.  
                    // If the membership ID exists, the current amount of purchases is increased by the purchase amount.
        public double Purchase()
        {
            Console.Write("Please enter the purchase amount: ");
            double purchaseAmount = Convert.ToDouble(Console.ReadLine());
            if (purchaseAmount > 0)
            {
                Console.Write("Are you sure you want to make this purchase? Enter 'Y' to confirm, or 'N' to cancel: ");
                string confirmPurchase = Console.ReadLine();
                if (confirmPurchase == "Y" || confirmPurchase == "y")
                {
                    Console.Write("The purchase was successful! ");
                    return currentPFM = currentPFM + purchaseAmount;
                }
                else if (confirmPurchase == "N" || confirmPurchase == "n")
                {
                    Console.WriteLine("Transaction cancelled. ");
                    return currentPFM;
                }
                else 
                {
                    Console.Write("Please enter either 'Y' or 'N'. Do you want to confirm this purchase? ");
                    confirmPurchase = Console.ReadLine();
                    if (confirmPurchase == "Y" || confirmPurchase == "y")
                    {
                        Console.Write("The purchase was successful! ");
                        return currentPFM = currentPFM + purchaseAmount;
                    }
                    else if (confirmPurchase == "N" || confirmPurchase == "n")
                    {
                        Console.WriteLine("Transaction cancelled. ");
                        return currentPFM;
                    }
                    else 
                    {
                        Console.Write("Please start over and enter either 'Y' or 'N' to confirm.");
                        return currentPFM;
                    }
                }
            }
            else
            {
                Console.Write("The purchase amount must be greater than $0. Please try again: ");
                purchaseAmount = Convert.ToDouble(Console.ReadLine());
                if (purchaseAmount > 0)
                {
                    Console.Write("Are you sure you want to make this purchase? Enter 'Y' to confirm, or 'N' to cancel: ");
                    string confirmPurchase = Console.ReadLine();
                    if (confirmPurchase == "Y" || confirmPurchase == "y")
                    {
                        Console.Write("The purchase was successful! ");
                        return currentPFM = currentPFM + purchaseAmount;
                    }
                    else if (confirmPurchase == "N" || confirmPurchase == "n")
                    {
                        Console.WriteLine("Transaction cancelled. ");
                        return currentPFM;
                    }
                    else 
                    {
                        Console.Write("Please enter either 'Y' or 'N'. Do you want to confirm this purchase? ");
                        confirmPurchase = Console.ReadLine();
                        if (confirmPurchase == "Y" || confirmPurchase == "y")
                        {
                            Console.Write("The purchase was successful! ");
                            return currentPFM = currentPFM + purchaseAmount;
                        }
                        else if (confirmPurchase == "N" || confirmPurchase == "n")
                        {
                            Console.Write("Transaction cancelled. ");
                            return currentPFM;
                        }
                        else 
                        {
                            Console.Write("Please start over and enter either 'Y' or 'N' to confirm.");
                            return currentPFM;
                        }
                    }
                }
                else 
                {
                    return currentPFM;
                }
            }
        }


        // Return method
        public double Return()
        {
            Console.Write("Please enter the return amount: ");
            double returnAmount = Convert.ToDouble(Console.ReadLine());
            if (returnAmount > 0)
            {
                Console.Write("Are you sure you want to return this item? Enter 'Y' to confirm, or 'N' to cancel: ");
                string confirmReturn = Console.ReadLine();
                if (confirmReturn == "Y" || confirmReturn == "y")
                {
                    Console.Write("The return was successful! ");
                    return currentPFM = currentPFM - returnAmount;
                }
                else if (confirmReturn == "N" || confirmReturn == "n")
                {
                    Console.WriteLine("Return transaction cancelled. ");
                    return currentPFM;
                }
                else 
                {
                    Console.Write("Please enter either 'Y' or 'N'. Do you want to confirm this return? ");
                    confirmReturn = Console.ReadLine();
                    if (confirmReturn == "Y" || confirmReturn == "y")
                    {
                        Console.Write("The return was successful! ");
                        return currentPFM = currentPFM - returnAmount;
                    }
                    else if (confirmReturn == "N" || confirmReturn == "n")
                    {
                        Console.WriteLine("Return transaction cancelled. ");
                        return currentPFM;
                    }
                    else 
                    {
                        Console.Write("Please start over and enter either 'Y' or 'N' to confirm.");
                        return currentPFM;
                    }
                }
            }
            else
            {
                Console.Write("The return amount must be greater than $0. Please try again: ");
                returnAmount = Convert.ToDouble(Console.ReadLine());
                if (returnAmount > 0)
                {
                    Console.Write("Are you sure you want to return this item? Enter 'Y' to confirm, or 'N' to cancel: ");
                    string confirmReturn = Console.ReadLine();
                    if (confirmReturn == "Y" || confirmReturn == "y")
                    {
                        Console.Write("The return was successful! ");
                        return currentPFM = currentPFM - returnAmount;
                    }
                    else if (confirmReturn == "N" || confirmReturn == "n")
                    {
                        Console.WriteLine("Return transaction cancelled. ");
                        return currentPFM;
                    }
                    else 
                    {
                        Console.Write("Please enter either 'Y' or 'N'. Do you want to confirm this return? ");
                        confirmReturn = Console.ReadLine();
                        if (confirmReturn == "Y" || confirmReturn == "y")
                        {
                            Console.Write("The return was successful! ");
                            return currentPFM = currentPFM - returnAmount;
                        }
                        else if (confirmReturn == "N" || confirmReturn == "n")
                        {
                            Console.Write("Return transaction cancelled. ");
                            return currentPFM;
                        }
                        else 
                        {
                            Console.Write("Please start over and enter either 'Y' or 'N' to confirm.");
                            return currentPFM;
                        }
                    }
                }
                else 
                {
                    return currentPFM;
                }
            }
        }


        // ApplyCBR method
        public abstract double ApplyCBR(); // apply cash-back rewards abstract method


        





        // to string
        public override string ToString()
        {
            return "Member ID: " + memberID + "  | Email: " + email + "  | CPFM *: " + String.Format("${0:n}",(currentPFM)) + "  | Member Type: " + memberType + "  | Annual Cost: " + String.Format("${0:n}",(annualCost));
        }

    }
}