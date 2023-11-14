using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses.Example1
{
    public class FileLog : ILog
    {
        string filepath;
        public FileLog(string path)
        {
            filepath = path;
            if (File.Exists(path) == false)
            {
                using (var fs = File.Create(path))
                {
                    fs.Close();
                }

            }
        }
        public void Log(string message)
        {
            File.AppendAllText(filepath, "\n" + message);
        }

        public void Log(string message, Exception exception)
        {
            File.AppendAllText(filepath, "\n" + message + "| Exception: " + exception.Message);
        }
    }
}
