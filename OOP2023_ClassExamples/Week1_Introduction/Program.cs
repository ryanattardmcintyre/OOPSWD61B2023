namespace Week1_Introduction
{

    //Class:  a collection of attributes and/or behaviours put together to represent ONE (abstract/real-world) entity 
    //        a class is like a blueprint or a template which defines an entity
    //        Person >> Name; Surname; IdCard; Dob, ...
    //        Product >> SerialNo, Category, Brand, Model, YearOfManufacture, ...

    //Object/Instance: An object is an abstract representation of related data stored in memory
    //        its when you start "personalizing" by giving values to the members of the class
    //        Person >> "Joe", "Borg", "123456", "1/1/2000", ...
    //        Product >> "1", "Mobiles", "Samsung", "S23", "2023", ...

    //Access Modifiers
    //they control access about the interaction of objects
    //public - most accessibility (least secure)
    //internal - gives you accessibility (to the class) within the same project
    //protected - gives you accessibility (to the class member) within the same class or an inherited class
    //private - least accessibilty (most secure)


    //Constructors
    //they enable you to create objects
    //a place where to code initialization code
    //a call to the constructor is p= new Person();
    //the effect: a new memory space will be created which allows you to start storing data within the object

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person p = new Person(); //Person is the class name
                                     //p is the object name
                                     //data can be stored in the object i.e. p


            //intellisense

            Department d = new Department();
            d.ID = 1;
            d.Name = "ICT";


            p.Department = d;

          
        }


        
    }
}