using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA23
{
    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Radius { get; set; }

        public Circle(int x, int y, double radius)
        {
            X = x;
            Y = y;
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
