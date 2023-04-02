using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class GroundPackage : Package
    {
        //Precondition: Specified values was created and not linked to anything yet. Base class values are merged with the current created ones.
        //Postcondition: The package information is the base class linked with Ground Package so no other values for the base constructor needs to rewritten.
        public GroundPackage(Address originAddress, Address destAddress, double pLength, double pWidth, double pHeight, double pWeight)
            : base(originAddress, destAddress, pLength, pWidth, pHeight, pWeight)
        {
            //Work is all done in the base constructor
        }

        // Creating a Zone Distance integer property that will calculate for the Zipcode
        public int ZoneDistance
        {
            get
            {
                //Precondition: Created a constant integer called FIRST_DIGIT_FACTOR and an integer called dist.
                //Postcondition: Made the dist integer equal a math equation made regarding the zip code criteria and returns the value.
                const int FIRST_DIGIT_FACTOR = 10000; // Denominator to extract 1st digit
                int dist; // Calculated zone distance

                //Makes the dist integer equal to a math calculation involving the originaddress and the destination address properties divided by the First_DIGIT_Factors and then subtracted
                dist = Math.Abs((OriginAddress.Zipcode / FIRST_DIGIT_FACTOR) - (DestinationAddress.Zipcode / FIRST_DIGIT_FACTOR));

                return dist;
            }
        }

        //An override decimal CalcCost to connected this class with the Package abstract class and to conduct the calculations this class needs.
        public override decimal CalcCost()
        {
            //Precondition: Created two const double numbered values named DIM_FACTOR and WEIGHT_FACTOR.
            //Postcondition: Returns the decimal class using a calculation to occur when returned.
            const double DIM_FACTOR = .15;
            const double WEIGHT_FACTOR = .07;

            return (decimal)(DIM_FACTOR * TotalDimension + WEIGHT_FACTOR * (ZoneDistance + 1) * Weight);
        }

        // An override string is created for the formating of the returned value
        public override string ToString()
        {
            //Precondition: Created a string NL value to provide space for formatting.
            //Postcondition: Returned the string format that will show the correct value.
            string NL = Environment.NewLine; 

            return $"Ground{base.ToString()}{NL}Zone Distance: {ZoneDistance}";
        }
    }
}
