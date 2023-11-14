using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses.Example4
{

    //CSV, JSON, TXT, ....

    public interface IFileHandle
    {
        void Create(string path); //creation is the same
        void Delete(string path); //deletion is the same

        void Edit(string path, string[] contents); //editing - its not the same across these different file extensions
    }
}
