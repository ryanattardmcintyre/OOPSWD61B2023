using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses
{
    //log: consists of a sentence or a phrase which describes a state/something that's happening within the application
    public interface ILog
    {
        void Log(string message);

        void Log(string message, Exception exception);
    }
}
