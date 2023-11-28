using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ku21
{
    public class Department
    {
        public Department() { }

        public Person dean { get; set; }
        List<Person> persons;
        public void AddToDepartment(Person person)
        {
            persons.Add(person);
        }

        public void SetDean(Person person)
        {
            this.dean = person;
        }
    }
}
