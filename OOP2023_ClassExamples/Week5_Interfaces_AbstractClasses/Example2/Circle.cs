using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses.Example2
{
    public class Circle : IShape, IPixel
    {
        public double Radius { get; set; }
        public double FindArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double FindPerimeter()
        {
          return Math.PI * 2 * Radius;
        }

        public void Plot(Graphics g, float x, float y)
        {
            g.DrawEllipse(new Pen(Brushes.Black),
                x, y, (float)(Radius * 2), (float)(Radius * 2));
        }
    }
}
