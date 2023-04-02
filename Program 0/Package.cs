using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    //Created an abstract class called Package and connected it with base class Parcel
    public abstract class Package : Parcel
    {
        private double _length;
        private double _width;
        private double _height;
        private double _weight;                                                                                                                                                                                                                 

        //Precondition: Length, Width, Height and Weight values was created and not linked to anything yet. Base class values are merged with the current created ones.
        //Postcondition: The package information was created with the specified values for pLength, pWidth, pHeight, and pWeight.
        public Package(Address originAddress, Address destAddress, double pLength, double pWidth, double pHeight,
            double pWeight) : base(originAddress, destAddress)
        {
            Length = pLength;
            Width = pWidth;
            Height = pHeight;
            Weight = pWeight;
        }

        //Length property is described and validated
        public double Length
        {
            //Precondition: None
            //Postcondition: The package's length has been returned
            get { return _length; }
            //Precondition: value > 0
            //Postcondition: The package's length has been set to the specified value
            set
            {
                if (value > 0)
                    _length = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Length), value, $"{nameof(Length)} must be > 0");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
            }
        }

        //Width property is described and validated
        public double Width
        {
            //Precondition: None
            //Postcondition: The package's width has been returned
            get { return _width; }
            //Precondition: value > 0
            //Postcondition: The package's width has been set to the specified value
            set
            {
                if (value > 0)
                    _width = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Width), value, $"{nameof(Width)} must be > 0");
            }
        }
        
        //Height property is described and validated
        public double Height
        {
            //Precondition: None
            //Postcondition: The package's height has been returned
            get { return _height; }
            //Precondition: value > 0
            //Postcondition: The package's height has been set to the specified value
            set
            {
                if (value > 0)
                    _height = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Height), value, $"{nameof(Height)} must be > 0");
            }
        }

        //Weight property is described and validated
        public double Weight
        {
            //Precondition: None
            //Postcondition: The package's weight has been returned
            get { return _weight; }
            //Precondition: value > 0
            //Postcondition: The package's weight has been set to the specified value
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Weight), value, $"{nameof(Weight)} must be > 0");
            }
        }

        // Created a protected double named Total Dimension
        protected double TotalDimension
        {
            //Precondition: None
            //Postcondition: The protected double returns the Length, Width, and Height together.
            get
            {
                return (Length + Width + Height);
            }
        }

        public override string ToString()
        {
            string NL = Environment.NewLine;//Newline shorthand

            return $"Package{NL}{base.ToString()}{NL}Length: {Length:N1}{NL}Width: {Width:N1}{NL}" +
                $"Height: {Height:N1}{NL}Weight: {Weight:N1}";
        }
    }
}
