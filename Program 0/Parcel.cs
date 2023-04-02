using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    // Describing Parcel as an abstract class 
    public abstract class Parcel
    {
        private Address _originAddress; // Private origin address property
        private Address _destinationAddress; // Private destination address property

        //Precondition: OriginAddress and DestinationAddress was created and not linked to anything yet.
        //Postcondition: The parcel information was created with the specified values for originAddress and destinationAddress
        public Parcel(Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }
        // OriginAddress property is evaluated
        public Address OriginAddress
        {
            //Precondition:None
            //Postcondition: The parcel's origin address has been returned
            get { return _originAddress; }
            // Precondition: value must not be null
            // Postcondition: The parcel's origin address has been set to the specified value
            set
            {
                // If loop has been made to make sure there is a result on if the value were to equal null and if it is not null there will be a correct value.
                if(value == null)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(OriginAddress)}", value, $"{nameof(OriginAddress)} must not be null");
                }
                else
                    _originAddress = value;
            }
        }
        // DestinationAddress property evaluated
        public Address DestinationAddress
        {
            //Precondition:None
            //Postcondition: The parcel's destination address has been returned
            get { return _destinationAddress; }
            // Precondition: value must not be null
            // Postcondition: The parcel's destination address has been set to the specified value
            set
            {
                // If loop has been made to make sure there is a result on if the value were to equal null and if it is not null there will be a correct value.
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(DestinationAddress)}", value, $"{nameof(DestinationAddress)} must not be null");
                }
                else
                    _destinationAddress = value;
            }
        }
        
        public abstract decimal CalcCost(); //An abstract object has been classified as CalcCost to help count the Parcel information.

        public override string ToString() //Override string is made to activate whenever the specified information is entered.
        {
            string NL = Environment.NewLine;
            return $"Origin Address: {NL}{OriginAddress}{NL}{NL}Destination Address:{NL}" +
                $"{DestinationAddress}{NL}Cost: {CalcCost()}";
        }
    }
}
