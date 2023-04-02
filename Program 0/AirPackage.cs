using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public abstract class AirPackage : Package
    {
        public const double HEAVY_THRESHOLD = 75; //Min weight of heavy package
        public const double LARGE_THRESHOLD = 100; //Min dimensions of large package

        //Precondition: Specified values was created and not linked to anything yet. Base class values are merged with the current created ones.
        //Postcondition: The package information is the base class linked with AirPackage so no other values for the base constructor needs to rewritten.
        public AirPackage(Address originAddress, Address destAddress, double pLength, double pWidth, double pHeight, double pWeight)
            : base(originAddress, destAddress, pLength, pWidth, pHeight, pWeight)
        {
            //all work done in base ctor
        }

        //A public bool property to describe when a package is too heavy 
        public bool IsHeavy()
        {
            return (Weight >= HEAVY_THRESHOLD); //Made to return the variable when the Weight is greater than or equal to the heavy threshold
        }

        //A public bool property to describe when a package is too large
        public bool IsLarge()
        {
            return (TotalDimension >= LARGE_THRESHOLD);//Made to return the variable when the TotalDimension is greater than or equal to the large threshold
        }

        // An override string is created for the formating of the returned value
        public override string ToString()
        {
            //Precondition: Created a string NL value to provide space for formatting.
            //Postcondition: Returned the string format that will show the correct value.
            string NL = Environment.NewLine;

            return $"Air{base.ToString()}{NL}Heavy: {IsHeavy()}{NL}Large: {IsLarge()}";
        }
    }
}
