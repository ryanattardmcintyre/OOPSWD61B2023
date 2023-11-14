using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses.Example4
{
    public class JsonFile : FileHandle
    {
        public override void Edit(string path, string[] contents)
        {
            string jsonString = JsonSerializer.Serialize(contents); //converting from object to a jsonstring


            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(jsonString);
                sw.Flush();
                sw.Close();
            }





        }
    }
}
