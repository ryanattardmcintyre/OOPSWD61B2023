using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace: its a top-level logical grouping in which you can create classes, enums, etc...
//           one namespace may have more than one class

namespace Week1_Introduction
{
    //GOOD PRACTICE:
    //1. classes are named starting with a capital letter (Pascal Case)
    //2. Do not include any numbers in the naming!!!
    //3. Class names are in SINGULAR
    internal class Person
    {
        //property: describe the characteristics of the entity/class you are building
        //          the medium through which we access/manage the field value
        //Good practices:
        //1. (Normally) properties are defined as public
        //2. Pascal Case with first letter being in capital casing
        //3. Do not include numbers in the naming
        //4. Singular please (where necessary)!
        public int Id { get; set; }
        public string IdCardNo { get; set; }
       
        public string FullName { get { return FirstName.ToUpper() + " " + LastName.ToUpper(); } }
        public DateTime Dob { get; set; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        //fields: have the same meaning of the properties but fields ARE ALWAYS private
        //        the place where the value is actually stored
        private string password;

        private string firstName;

        private string lastName;







    }
}
