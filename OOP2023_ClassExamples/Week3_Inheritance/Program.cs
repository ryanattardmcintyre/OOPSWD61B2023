using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.X = 10;
            p.Y = 15;
            p.Color = Color.Black;

            Point p2 = new Point(40, 50);
            



            Circle c = new Circle();
            c.X = 50;
            c.Y = 50;
            c.Color = Color.Black;
            c.Radius = 100;

            Console.WriteLine(p.Draw());
            Console.WriteLine(c.Draw());
            Console.ReadKey();


        }
    }
}
