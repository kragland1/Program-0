using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    public class TwoDayAirPackage : AirPackage
    {
        public enum Delivery { Early, Saver}// An enum property was created named Delivery with the values of either Early or Saver.

        private Delivery _deliveryType; // A private property named Delivery used for the different kinds of deliveries.

        //Precondition: Specified values was created and not linked to anything yet. Base class values are merged with the current created ones.
        //Postcondition: DeliveryType property was created and linked to the delType Delivery property.
        //The package information is the base class linked with TwoDayAirPackage so no other values for the base constructor needs to be rewritten.
        public TwoDayAirPackage(Address originAddress, Address destAddress, double pLength, double pWidth, double pHeight, double pWeight, Delivery delType)
            : base(originAddress, destAddress, pLength, pWidth, pHeight, pWeight)
        {
            DeliveryType = delType;
        }

        //Delivery Type method is created for the different types
        public Delivery DeliveryType
        {
            //Precondition: None
            //Postcondition: Returns the _deliveryType property and sets an if-else loop where if the enum type is part of the Delivery property it will equal the
            //value and if not it will show a string format specifying that it needs to either be an early delivery or a saver one.
            get { return _deliveryType; }
            set
            {
                if (Enum.IsDefined(typeof(Delivery), value))
                {
                    _deliveryType = value;
                }
                else
                    throw new ArgumentOutOfRangeException(nameof(DeliveryType), value,$"{nameof(DeliveryType)} must be {nameof(Delivery.Early)}" +
                        $"or {nameof(Delivery.Saver)}");
            }
        }

        //A public override decimal method that incorpoartaes calccost and makes it become associated with the abstract class as well
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = 0.18; //Dimension coefficient in cost equation
            const double WEIGHT_FACTOR = 0.2; //Weight coefficient in cost equation
            const decimal DISCOUNT_FACTOR = 0.15M; //Discount factor in cost equation

            decimal cost; //Decimal property named cost.

            //Precondition: Properties DIM_FACTOR, WEIGHT_FACTOR ,and DISCOUNT_FACTOR were created and labled.
            //Postcondition: Cost was given a decimal equation that will occur whenever the cost is given. There will also be
            //a if loop that will occur with the cost amount if the DeliveryType property is equal to the Delivery.Saver one. The cost value will then be returned.
            cost = (decimal)(DIM_FACTOR * TotalDimension + WEIGHT_FACTOR * Weight);

            if(DeliveryType == Delivery.Saver)
            {
                cost *= (1 -DISCOUNT_FACTOR);
            }

            return cost;
        }

        // An override string is created for the formating of the returned value
        public override string ToString()
        {
            //Precondition: Created a string NL value to provide space for formatting.
            //Postcondition: Returned the string format that will show the correct value.

            string NL = Environment.NewLine;//Newline shorthand

            return $"TwoDay{base.ToString()}{NL}Delivery Type: {DeliveryType}";
        }

    }
}
