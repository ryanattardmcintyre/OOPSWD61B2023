using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week5_Interfaces_AbstractClasses.Example4
{
    public class CSVFile : FileHandle
    {
        public override void Edit(string path, string[] contents)
        {
            string contentsMerged = "";
            foreach (string line in contents) {
                contentsMerged += line + ";";
            }

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(contentsMerged);
                sw.Flush();
                sw.Close();
            }
        }
    }
}
