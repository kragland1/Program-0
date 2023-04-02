using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class NextDayAirPackage : AirPackage
    {
        private decimal _expressFee;// A decimal property for the express fees 

        //Precondition: Specified values was created and not linked to anything yet. Base class values are merged with the current created ones.
        //Postcondition: Express Fee property was created a linked to the expFee decimal property.
        //The package information is the base class linked with NextDayAirPackage so no other values for the base constructor needs to be rewritten.
        public NextDayAirPackage(Address originAddress, Address destAddress, double pLength, double pWidth, double pHeight, double pWeight, decimal expFee)
            : base(originAddress, destAddress, pLength, pWidth, pHeight, pWeight)
        {
            ExpressFee = expFee;
        }

        //A public decimal class was created for the new ExpressFee property
        public decimal ExpressFee
        {
            //Precondition: None
            //Postcondition: Returns the _expressFee property to it and makes a private set that uses an if-else loop to show the correct value in the specified string format.
            get { return _expressFee; }
            private set
            {
                if(value >= 0)
                    _expressFee = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(ExpressFee), value, $"{nameof(ExpressFee)} must be >= 0");
            }
        }

        // A public override decimal method is created to calculate a certain cost
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = 0.35; //Dimension coefficient in cost equation
            const double WEIGHT_FACTOR = 0.25; // Weight coefficient in cost equation
            const double HEAVY_FACTOR = 0.2; //Heavy coefficient in cost equation
            const double LARGE_FACTOR = 0.22; //Large coefficient in cost equation

            decimal cost;// A decimal property to describe and show the cost

            //Precondition: Properties DIM_FACTOR, WEIGHT_FACTOR, HEAVY_FACTOR and LARGE_FACTOR were created and labled.
            //Postcondition: Cost was given a decimal equation that will occur whenever the cost is given. There will also be
            //two if loops that will occur with the cost amount if it is too heavy or too large. The cost will then be returned
            //after any of the calculations. 

            cost = (decimal)(DIM_FACTOR * TotalDimension + WEIGHT_FACTOR * Weight) + ExpressFee;

            if (IsHeavy())
            {
                cost += (decimal)(HEAVY_FACTOR * Weight);
            }

            if (IsLarge())
            {
                cost += (decimal)(LARGE_FACTOR * TotalDimension);
            }

            return cost;
        }

        // An override string is created for the formating of the returned value
        public override string ToString()
        {
            //Precondition: Created a string NL value to provide space for formatting.
            //Postcondition: Returned the string format that will show the correct value.
            
            string NL = Environment.NewLine;//Newline shorthand

            return $"NextDay{base.ToString()}{NL}Express Fee: {ExpressFee:C}";
        }
    }
}
