using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    // A class was made called Letter that is connected to the Parcel class
    internal class Letter : Parcel
    {
        private decimal _fixedCost;// A private decimal property called fixedCost

        // A public class for the internal Letter class that list the names of the Parcel class and connects it to the Letter one
        //Precondition:  Parcel class properties are listed into the public Letter class including an added one called "cost"
        //Postcondition: Fixed Cost is a new property created a linked to the "decimal cost" previous property
        public Letter (Address originAddress, Address destinationAddress, decimal cost) : base(originAddress,destinationAddress)
        {
            FixedCost = cost;
        }

        public decimal FixedCost
        {
            get { return _fixedCost; }
            //Precondition: value >= 0
            //Postcondition: The letter's fixed cost has been set to the specified value
            set
            {
                //If loop was made to show the result of the loop if the value from the fixedCost is greater than or equal to 0
                if(value >= 0)
                {
                    _fixedCost = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"{nameof(FixedCost)}", value, $"{nameof(FixedCost)} must be >= 0");
                }
            }
        }

        public override decimal CalcCost() // An override decimal that uses the CalcCost Method to execute it
        {
            return FixedCost;// Returns the FixedCost property
        }

        public override string ToString() // An override string that will be executed and formatted the way it is described when specific criteria is submitted.
        {
            string NL = Environment.NewLine;
            return $"Letter{NL}{base.ToString()}";
        }
    }
}
