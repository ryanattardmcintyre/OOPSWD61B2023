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
    public class Person
    {
        //note:
        //by default: constructors are there but hidden
        //the moment you decide to type it, it replaces the hidden one
        //a constructor without parameters is said to be the default constructor
        public Person()
        {
            createdOn =  DateTime.Now;
        }

      
        public string ChangePassword(string newPassword, string confirmationPassword)
        {
            if (newPassword.Length < 6)
            {
                return "Password is too simple; has to be more than 6 alphanumeric characters";
            }


            if 
                (newPassword == confirmationPassword
                )
            {
                password = newPassword;
                return "Password Changed successfully";
            }
            else { return "Confirmation Password does not match the specified password";
            }

        }

        //property: describe the characteristics of the entity/class you are building
        //          the medium through which we access/manage the field value
        //Good practices:
        //1. (Normally) properties are defined as public
        //2. Pascal Case with first letter being in capital casing
        //3. Do not include numbers in the naming
        //4. Singular please (where necessary)!

        //Advantages of using properties to access the data
        //1. one is enabled to control the access to/from the data
        //2. one can tranform the data
        //3. they offer a more secure approach to access the data indirectly


        //fields are normally private
        //private: camel case
        public int Id { get; set; }
        public string IdCardNo { get; set; }
        public DateTime Dob { get; set; }

        private DateTime createdOn;
        public int Age { get
            {
                return DateTime.Now.Year - Dob.Year;
            } 
        }
       
        //fields: have the same meaning of the properties but fields ARE ALWAYS private
        //        the place where the value is actually stored
        private string password;
        public string FirstName
        {
            get {
              return  firstName[0].ToString().ToUpper()
                    + firstName.Substring(1).ToLower();
            }

            set
            {
                firstName = value;
            }
        }

        private string firstName; //Joe

        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public Department Department { get; set; }
        
    }
}
