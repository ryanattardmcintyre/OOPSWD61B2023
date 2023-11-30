using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace AA23
{

    public abstract class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        protected Point(int x, int y)
        { X = x; Y = y; }
    }
    public class Circle: Point
    {
       
        public double Radius { get; set; }

        public Circle(int x, int y, double radius): base(x,y)
        {
            
            Radius = radius;
        }
    }

    public class Sphere : Circle
    {
        public int Z { get; set; }

        public Sphere(int x, int y, int z, double radius) : base(x, y, radius)
        { Z = z; }
    }

    public class Cylinder: Sphere
    {
        public double Length { get; set; }

        public Cylinder(int x, int y, int z, double radius, double length) : base(x, y,z, radius)
        { Length = length; }
    }
}
