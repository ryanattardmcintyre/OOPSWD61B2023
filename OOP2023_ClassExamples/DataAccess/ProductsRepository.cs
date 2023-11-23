using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductsRepository: MyConnection
    {
        public ProductsRepository():base() { }



        //List -> it makes a call to the database immediately
        //IQueryable -> it postpones the call to the database until you decide

        /// <summary>
        /// This method will return all the products from the database
        /// </summary>
        /// <returns></returns>
        public IQueryable<Product> GetProducts() { 
            //Select * From Products

            return Context.Products.AsQueryable(); //gets the entire list of products



        }

        public Product GetProductById(int id) { 

            //Select Top 1 Id, Name, Price From Products Where Id == $id

            return GetProducts().SingleOrDefault(p => p.Id == id);
        
        }

        public IQueryable<Product> GetProducts(string keyword) { 
            //Select * From Products Where Name like '%$keyword%'

        return GetProducts().Where(p => p.Name.Contains(keyword)).OrderByDescending(x=>x.Price);
        
        }

        public void AddProduct(Product product) { 
        
            Context.Products.Add(product);//adds the product in memory to the context (property) which is representing the database
            Context.SaveChanges(); //commits/saves what's inside the memory into the database

        }

        public void DeleteProduct(Product product) { }  

        public void UpdateProduct(Product product) { }

      

    

    }
}
