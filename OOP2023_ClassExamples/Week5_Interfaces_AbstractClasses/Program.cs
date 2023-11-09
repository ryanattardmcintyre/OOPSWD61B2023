namespace Week5_Interfaces_AbstractClasses
{

    //interfaces: (1) interfaces are like classes without any implementation
                //(2) they force future development (classes that inherit the interface) to abide with the declrations inside the interface
                //(3) a class can inherit multiple interfaces whereas a class can inherit up to 1 class

    //            (when is it) use(d)? interfaces may be used when you need a base class for a number of classes
                //                     and you do not know what to put inside the implementations
                // use 2: ...so you dictate how the inherited classes should look like without giving in depth implementation


    internal class Program
    {
        static void Main(string[] args)
        {
            ILog myWayOfLogging = new FileLog("logs.txt");
            
            


            Console.WriteLine("Input a number from 1 to 10: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 1 || number > 10) throw new Exception("Number falls out of range");
                else
                {
                    Console.WriteLine("Valid input");

                }
            }
            catch (Exception ex)
            {
                myWayOfLogging.Log("An error was raised", ex); 
                //logs will either be saved in a file or sent out as an email...depending on line 13

            }

            Console.WriteLine("Press a key to quit...");
            Console.ReadKey();





            PersonList pl = new PersonList();
            Person p1 = new Person() { Id=1, Name="Joe", Surname="Borg"};
            Person p2 = new Person() { Id = 1, Name = "Mary", Surname = "Borg" };

            pl.Add(p1);
            if (pl.IndexOf(p2) == -1)
            {
                pl.Add(p2);
            }
        }
    }
}