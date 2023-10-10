using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Introduction
{
    /*
                 * Person
            - Id
            - FirstName
            - LastName

            Vehicle
            -properties:

            Model .e.g. Rav4
            Make e.g. Toyota
            Engine (Petrol/Diesel/Hybrid/Electric)
            Year
            Colour
            EngineSize
            List<Person> Owners

            - constructor
            to do: initialize the List<Person> Owners;

            - method
            int FindAgeOfCar(); //calculates how many years is the car old?
            string ListCarOwners(); //returns all the owner details concatenated
            double CalculateSpeed(double distance, double time); //distance is in km while time is in hours
*/


 public enum Engine { Petrol, Diesel, Hybrid, Electric}; //enums are declared in the namespace
  
    public class Vehicle
    { 

        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public double EngineSize { get; set; }

        public List<Person> Owners { get; set; }

        public Engine Engine { get; set; }

        public Vehicle()
        {
            Year = 0;
            Colour = "";

            Owners = new List<Person>();
        }

        public int FindAgeOfCar()
        {
            return DateTime.Now.Year - Year;
        }
        public string ListCarOwners()
        {
            string output = "";
            foreach (Person person in Owners)
            {
                output += $"Id: {person.Id}, Full name: {person.FullName}\n";
            }
            return output;
        }

        /// <summary>
        /// This method calculates the speed in km/h
        /// </summary>
        /// <param name="distance">Value in km</param>
        /// <param name="time">Value in hours</param>
        /// <returns>km/h</returns>
        public double CalculateSpeed(double distance, double time)
        {
            return distance / time;
        }

    }
}
