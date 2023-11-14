using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses.Example2
{
    public interface IShape //assume its a 2d shape
    {
        double FindArea();
        double FindPerimeter();
    }
}
