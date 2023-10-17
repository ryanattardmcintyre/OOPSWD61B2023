using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Inheritance
{
    public class Cylinder: Circle
    {
        public int Z { get;set; }

        public double Height { get; set; }

        public override string Draw()
        {
            return $"This is a cylinder with X:{X}, Y:{Y}, Z: {Z}, Radius: {Radius}, Height: {Height}";

        }

        public override double FindArea()
        {
            //Cylinder area: area of a circle x2 + 2*Pi*R*Height
            return (base.FindArea() * 2) + ((2 * Math.PI * Radius) * Height);
        }
    }
     
}
