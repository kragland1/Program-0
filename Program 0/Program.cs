// Student ID: 5379658
// Progam 0
// 09/10/2022
// CIS - 200 - 75 - 4228
// Progam.cs is the main class that test the variables, Address.cs is the class that list the adresses,
// Parcel.cs is the class that computes certain numbers and works along side the addresses on where to deliver them
// Letter.cs is the class that uses computation on the cost and delivery.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_0
{
    internal class Program
    {
        // Precondition: None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address(" Jacob Treeven ", "345 South Reverend St.", "Apt.72", "Louisville", "KY", 43604);// Test Address 1
            Address a2 = new Address("David Hassell", "433 Surfer Lane Ave.", "Apt. 84", "Danville", "FL", 55005);// Test on Address 2
            Address a3 = new Address("Danny Fenton", "552 Silver Surfer St.", "Lane. 76", "Bowling Green", "KY", 87754); // Test on Address 3
            Address a4 = new Address("Bobby Bobberton", "332 Jumping Dragons Ave.", "Suite 541", "Miami", "FL", 66033); // Test on Address 4

            Letter letter1 = new Letter(a1, a2, 3.95M); // Letter test object 
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5); // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15, 85, 7.50M); // Next Day test object
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, 80.5, TwoDayAirPackage.Delivery.Saver); // Two Day test object

            List<Parcel> parcels; //List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);

            //Display Data
            WriteLine("Original List:");
            WriteLine("======================");

            // Foreach loop that will potray the writelined objects shown below
            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("-----------------");
            }

        }
    }
}
