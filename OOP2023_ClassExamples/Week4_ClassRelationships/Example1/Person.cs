using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

    }

    public class Room
    {
        public int Id { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
    }

    public class Valuation
    {
        public double Value { get; set; }
        public Person Agent { get; set; }

        public DateTime Date { get; set; }

    }
}
