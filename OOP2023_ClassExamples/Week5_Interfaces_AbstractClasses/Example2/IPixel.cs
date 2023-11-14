using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Week5_Interfaces_AbstractClasses.Example2
{
    public interface IPixel
    {
        void Plot(Graphics g, float x, float y);
    }
}
