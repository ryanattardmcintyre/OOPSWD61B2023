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
           Person p = new Person(); //Person is the class name
                                    //p is the object name
                                    //data can be stored in the object i.e. p

            Console.WriteLine("Type in your first name:");
            p.FirstName = Console.ReadLine();

            Console.WriteLine("Type in your last name:");
            p.LastName = Console.ReadLine();

            Console.WriteLine($"Your full name: {p.FullName}");


            Vehicle v = new Vehicle();
            Console.WriteLine("Input vehicle Make");
            v.Make = Console.ReadLine();

            Console.WriteLine("Input vehicle model");
            v.Model = Console.ReadLine();

            Console.WriteLine("Input vehicle year");
            v.Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Petrol");
            Console.WriteLine("2. Diesel");
            Console.WriteLine("3. Hybrid");
            Console.WriteLine("4. Electric");
             
           int engineChoice = Convert.ToInt32(Console.ReadLine());
            switch(engineChoice)
            {
                case 1:
                    v.Engine = Engine.Petrol; break;
                case 2:
                    v.Engine = Engine.Diesel; break; 
            }

            /* v.Engine = (Engine) Enum.Parse(typeof(Engine), Console.ReadLine());*/

            v.Owners.Add(p);

            Console.WriteLine(); //skips a line

            Console.WriteLine($"Vehicle engine is: {v.Engine}");
            Console.WriteLine($"Age of car is {v.FindAgeOfCar()}");
            Console.WriteLine($"List of Owners \n {v.ListCarOwners()}");


            Console.WriteLine();
            Console.WriteLine("Press any key to terminate application");
            Console.ReadKey();
          
        }


        
    }
}