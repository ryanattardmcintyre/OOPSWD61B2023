using Common;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //idea: to declare and instantiate productsRepository ONCE and use it wherever or whenever i need it, keeping ONE instance in memory
            ProductsRepository productsRepository = new ProductsRepository();
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. List Products");
                Console.WriteLine("2. Search Products");
                Console.WriteLine("3. See Product Details");
                Console.WriteLine("4. Add a Product");
                Console.WriteLine("5. Delete a Product");
                Console.WriteLine("6. Update Product");
                Console.WriteLine("7. List Categories With No. of Products");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("999. Quit");

                Console.WriteLine("Input choice:");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Menu choice out of range or doesn't exist");
                    Console.WriteLine("Hit a key to continue...");
                    Console.ReadKey();

                    choice = 1000;
                }

                //starts the code neede for executing the individual menu items

                switch(choice)
                {
                    case 1:

                        
                        var list = productsRepository.GetProducts();

                        ListProducts(list);
                       
                        Console.WriteLine("Hit a key to go back to the main menu...");
                        Console.ReadKey();
                        break;

                    case 2:

                        Console.WriteLine("What are you looking for?");
                        string keyword = Console.ReadLine();

                       
                        var list2 = productsRepository.GetProducts(keyword);

                        ListProducts(list2);

                        Console.WriteLine("Hit a key to go back to the main menu...");
                        Console.ReadKey();

                        break;


                    default:
                        Console.WriteLine("Menu choice out of range or doesn't exist");
                        Console.WriteLine("Hit a key to continue...");
                        Console.ReadKey();
                        break;
                }



            } while (choice != 999);

        }

        static void ListProducts(IQueryable products)
        {
            Console.Clear();
            foreach (Product item in products)
            {
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Price: Eur{item.Price}");
                Console.WriteLine($"Category: {item.Category.Name}"); //end user would like to see the category name
                Console.WriteLine();

            }
        }




    }
}
