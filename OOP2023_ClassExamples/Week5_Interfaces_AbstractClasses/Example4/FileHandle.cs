using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week5_Interfaces_AbstractClasses.Example4
{
    //note: an abstract class is like a hybrid between an interface and a normal class, in the sense that it can be inherited only ONCE
    //      but it allows implemented method or unimplemented methods live side-by-side

    //note: an abstract class (like an interface) cannot be instantiated; its there simply to be inherited
    public abstract class FileHandle : IFileHandle
    {
        public void Create(string path)
        {
            using (var myFile =File.Create(path)) //always use the "using" clause, because the curled brackets act as a safe-close to the file
            {
                myFile.Close();
            } //after which file is closed
        }

        public void Delete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            
        }

        public abstract void Edit(string path, string[] contents); //postpones the implementation when this class will be inherited
        
    }
}
