using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses
{
    public class FileLog : ILog
    {
        string filepath;
        public FileLog(string path) { filepath = path;
            if (System.IO.File.Exists(path) == false)
            {
                using (var fs = System.IO.File.Create(path))
                {
                    fs.Close();
                }
                
            }
        }    
        public void Log(string message)
        {
            System.IO.File.AppendAllText(filepath, "\n"+message);
        }

        public void Log(string message, Exception exception)
        {
            System.IO.File.AppendAllText(filepath, "\n" + message + "| Exception: " + exception.Message);
        }
    }
}
