using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Inheritance
{
    //Circle inherits from Point so Circle is the derived class while
    //Point is the base class
    //Circle is a different class but it is a Point with extra members
    public class Circle: Point
    {
        public double Radius { get; set; }

        //part 2: dynamic polymorphism
        public override string Draw()
        {
            return  $"This is a circle with X:{X}, Y:{Y}, Radius:{Radius}";
        }

        //Exercise: Create a method that finds the Area of a circle, but the method can be 
        //          overriden in cylinder to find the surface area of a cylinder
        //Circle area: Math.Pi x radius (squared)
        //Cylinder area: area of a circle x2 + 2*Pi*R*Height


        public virtual double FindArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
