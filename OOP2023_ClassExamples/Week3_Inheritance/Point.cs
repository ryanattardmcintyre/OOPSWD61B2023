using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Inheritance
{
    public class Point
    {
        //default constructor
        public Point() { }

        //non-default constructor (static polymorphism)
        public Point(int x, int y)
        {
            X = x;
            Y = y;
            this.Color = Color.Black;
        }

        public Point(int x, int y, Color c) : this(x, y)
        {
            Color = c;
        }


        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; } //Color is a built-in class

        //Part 1 of dynamic polymorphism
        //dynamic polymorphism enables you to change the implementation of the method
        // in the inherited classes
        public virtual string Draw() {
            return $"This is a point with X:{X}, Y:{Y}";
        }


        //protected means that this field will be available only to the derived classes
        protected int BrushSize;
    }
}
