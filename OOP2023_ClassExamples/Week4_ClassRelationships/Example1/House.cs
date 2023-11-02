using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships
{

   
    //Composition (most strict)
    //Example: House and Person
    //Why: House must have an owner; A House instance cannot exist without
    //     first providing the owner
    //How: you have to declare a constructor which forces the developer to input
           //an owner

    //Aggregation
    //Example: House and Room/ Valuation and Person
    //Why: House can still exist without adding rooms


    //Association
    //Example: House and Valuation
    //Why: Valuation is never stored within House but only used!
    public class House
    {
        public House(Person owner) { 
        Owner = owner;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public Person Owner { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
        public void AddRoom(Room r) { 
            Rooms.Add(r);
        }
        public double CalculateTax(Valuation valuation, double rate=8)
        {
            return (rate / 100) * valuation.Value;
        }

    }
}
