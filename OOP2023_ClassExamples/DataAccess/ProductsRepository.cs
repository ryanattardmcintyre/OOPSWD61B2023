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
            

            //notation: entity-models
            //return Context.Products.AsQueryable(); //gets the entire list of products

            //notation: linq
            //Select * From Products
            var list =  from product in Context.Products
                        //join category in Context.Categories 
                        //on product.CategoryFk equals category.Id
                        select product;
            return list.AsQueryable();
        }

        public Product GetProductById(int id) {

            //Select Top 1 Id, Name, Price From Products Where Id == $id
            //if no match , this method will return a null
            //return GetProducts().SingleOrDefault(p => p.Id == id);

            var list = from product in Context.Products
                       where product.Id == id
                       select product;
            return list.FirstOrDefault();

        }

        public IQueryable<Product> GetProducts(string keyword) { 
            //Select * From Products Where Name like '%$keyword%'

          //  return GetProducts().Where(p => p.Name.StartsWith(keyword)).OrderByDescending(x=>x.Price);

            var list = from product in Context.Products
                       where product.Name.StartsWith(keyword)
                       orderby product.Price descending
                       select product;
            return list.AsQueryable();

        }

        public void AddProduct(Product product) { 
        
            Context.Products.Add(product);//adds the product in memory to the context (property) which is representing the database
            Context.SaveChanges(); //commits/saves what's inside the memory into the database

        }

        public void DeleteProduct(Product product) {
            Context.Products.Remove(product);
            Context.SaveChanges();
        }  

        public void UpdateProduct(Product product) {

            var originalProduct = GetProductById(product.Id);
            originalProduct.Name = product.Name;
            originalProduct.Price = product.Price;
            originalProduct.CategoryFk = product.CategoryFk;

            Context.SaveChanges();
        
        }

      

    

    }
}
