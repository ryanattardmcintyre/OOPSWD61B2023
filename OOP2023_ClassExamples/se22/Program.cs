using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se22
{
    /*
     *
     •	A class Canvas 
o	has two fields [1]
	components which is a list of type Element
	name  of type string
o	A behaviour in the same class called AddComponent should allow the addition of new elements to the list above; [1]
o	An object of type Canvas must have width and height set via an object of type Dimension and a given name; [1]

•	 A class Element has two properties [1]
o	X of type int
o	Y of type int
and a behaviour called Draw(System.Drawing.Graphics g) which should draw a pixel on screen using the g parameter; [2]

•	A class Dimension has two properties [1]
o	Width of type double
o	Height of type double

     */


    public class Canvas
    {
        private List<Element> components;
        private string name;

        public void AddComponent(Element e) { components.Add(e); }

        private double width;
        private double height;
        public Canvas(Dimension d, string _name)
        {
            name = _name;
            width = d.Width;
            height = d.Height; 
        }
    }
    public class Element
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw(System.Drawing.Graphics g)
        { g.DrawLine(new Pen(Brushes.Black), X, Y, X, Y); }
    }
    public class Dimension
    {
        public double Width { get; set; }
        public double Height { get; set; }

    }










    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
