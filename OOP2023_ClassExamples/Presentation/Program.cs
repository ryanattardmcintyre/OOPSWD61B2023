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
            CategoriesRepository categoriesRepository = new CategoriesRepository();

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


                    case 3:
                        int id = 0;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Input product id to show details:");
                            try
                            {
                                id = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                id = -1;
                                Console.WriteLine("Input is invalid. Hit a key to re-input the id...");
                                Console.ReadKey();

                            }
                        } while (id == -1);

                        var myProduct = productsRepository.GetProductById(id);
                        if (myProduct==null)
                        {
                            Console.WriteLine("Product was not found");

                         
                        }
                        else
                        {
                            List<Product> myListOfOneProduct = new List<Product>() { myProduct };
                            ListProducts(myListOfOneProduct.AsQueryable());
                        }

                            Console.WriteLine("Hit a key to continue...");
                            Console.ReadKey();
                        break;


                    case 4:

                        Console.Clear();
                        Product myNewProduct = new Product();
                        Console.WriteLine("Input a product name: ");
                        myNewProduct.Name = Console.ReadLine();

                        do
                        {
                            try
                            {
                                Console.WriteLine("Input product price: ");
                                myNewProduct.Price = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch
                            {
                                myNewProduct.Price = -1;
                                Console.WriteLine("Input is invalid. Hit a key to re-input the price...");
                                Console.ReadKey();

                            }
                        } while (myNewProduct.Price < 0);



                        var myCategories = categoriesRepository.GetCategories();
                        Console.WriteLine();
                        foreach (var category in myCategories)
                        {
                            Console.WriteLine($"{category.Id}. {category.Name}");
                        }
                        Console.WriteLine() ;   

                        Console.WriteLine("Input Category Id [the number next to the category name]: ");
                        myNewProduct.CategoryFk = Convert.ToInt32(Console.ReadLine());

                        if(myNewProduct.CategoryFk < myCategories.Min(x=>x.Id)
                            && myNewProduct.CategoryFk > myCategories.Max(x=>x.Id))
                        {
                            //category is not valid
                            //checking with the list of categories, whether the input category id
                            //falls within range

                            Console.WriteLine("Category input is not valid");
                        }
                        else
                        {
                            productsRepository.AddProduct(myNewProduct);
                            Console.WriteLine("Product was inserted successfully in the database");
                        }

                        Console.WriteLine("Hit a key to continue...");
                        Console.ReadKey();

                        break;

                    case 7:

                        var mySummary = categoriesRepository.GetCategoriesSummaries();

                        Console.WriteLine("Category Id \t Category Name \t Total Products");
                        foreach (var item in mySummary)
                        {
                            Console.WriteLine($"{item.Category.Id} \t {item.Category.Name} \t {item.TotalNoOfProducts}");
                        }
                        Console.WriteLine();
                        Console.WriteLine("Hit a key to continue...");
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

        static void ListProducts(IQueryable<Product> products)
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
