using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_0
{
    //A class called "Address" is created with the properties stated being the name, addressline1, addressline2, city, state, and the zipcode.
    public class Address
    {
        private string _name;
        private string _addressline1;
        private string _addressline2;
        private string _city;
        private string _state;
        private int _zipcode;

        //PreCon: name, address1, city, state may not be null, empty nor all whitespace
        //PostCon: The address was created with the specified values for name, address1, address2, city, state, and zipcode
        public Address(string name, string addressline1, string addressline2, string city, string state, int zip)
        {
            Name = name;
            Addressline1 = addressline1;
            Addressline2 = addressline2;
            City = city;
            State = state;
            Zipcode = zip;
        }

        public Address(string name, string addressline1, string city, string state, int zip)
        {
            //Body describes that Addressline2 will be blank for this one
            Name = name;
            Addressline1 = addressline1;
            Addressline2 = null;
            City = city;
            State = state;
            Zipcode = zip;
        }

        public string Name
        {
            //Precondition: None
            // Postcondition: The address' name has been returned
            get { return _name; }
            // Precondition: Value must not be null, empty nor all whitespace
            // Postcondition: The address' name has been set to the specified value
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(Name)}", value, $"{nameof(Name)} must not be empty");
                else
                    _name = value.Trim();
            }
        }
        public string Addressline1
        {
            //Precondition: None
            // Postcondition: The address' first line has been returned
            get { return _addressline1; }
            // Precondition: Value must not be null, empty nor all whitespace
            // Postcondition: The address' first line has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(Addressline1)}", value, $"{nameof(Addressline1)} must not be empty");
                else
                    _addressline1 = value.Trim();
            }
        }
        public string Addressline2
        {
            //Precondition: None
            // Postcondition: The address' second line has been returned
            get { return _addressline2; }
            // Precondition: None
            // Postcondition: The address' second line has been set to the specified value
            set
            {
                if (value == null) // Just in case
                    value = string.Empty;
                else
                    _addressline2 = value.Trim();
            }
        }
        public string City
        {
            //Precondition: None
            // Postcondition: The address' city has been returned
            get { return _city; }
            // Precondition: Value must not be null, empty nor all whitespace
            // Postcondition: The address' city has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(City)}", value, $"{nameof(City)} must not be empty");
                else
                    _city = value.Trim();
            }
        }
        public string State
        {
            //Precondition: None
            // Postcondition: The address' state has been returned
            get { return _state; }
            // Precondition: Value must not be null, empty nor all whitespace
            // Postcondition: The address' state has been set to the specified value
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentOutOfRangeException($"{nameof(State)}", value, $"{nameof(State)} must not be empty");
                else
                    _state = value.Trim();
            }
        }
        public int Zipcode
        {
            //Precondition: None
            // Postcondition: The address' zip code has been returned
            get { return _zipcode; }
            // Precondition: value < 0 or value > 99999 it will show an error message
            // Postcondition: The address' zip code has been set to the specified value
            set
            {
                if (_zipcode < 0 || _zipcode > 99999)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(Zipcode)}", value, $"{nameof(Zipcode)} must be U.S. 5 digit zip code");
                }

                _zipcode = value;
            }
        }

        // Override string was created to be activated after certain criteria is submitted. This below will be how the worded information will be formatted.
        public override string ToString()
        {
            string NL = Environment.NewLine;
            string result;

            result = $"{Name}{NL}{Addressline1}{NL}";

            if(string.IsNullOrWhiteSpace(Addressline2))
            {
                result += $"{Addressline2}{NL}";
            }

            result += $"{City}, {State}, {Zipcode:D5}";

            return result;
        }
    }
}
