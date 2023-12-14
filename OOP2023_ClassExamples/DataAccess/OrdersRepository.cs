using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrdersRepository: MyConnection
    {
        public OrdersRepository() : base() { }


        /*
         *    Console.WriteLine("8. List the no. of paid or not paid orders");
                Console.WriteLine("9. List the no. of orders for every product");
                Console.WriteLine("10. List the no. of orders for every category");
                Console.WriteLine("11. List the total price for every order per category");
         */


        public IQueryable<Feature8ViewModel> GetPaidOrUnpaidNoOfOrders()
        {
            //  Unpaid 1
            //  Paid   2
            /*
             *   var list = from product in Context.Products
                       group product by product.Category into newGroup
                       select new CategorySummaryViewModel()
                       {
                           Category = newGroup.Key,
                           TotalNoOfProducts = newGroup.Count()
                       };

             * */

            var list = from order in Context.Orders
                       group order by order.Paid into ordersByPaid
                       select new Feature8ViewModel()
                       {
                           Label = (ordersByPaid.Key == true ? "Paid Orders" : "Unpaid Orders"),
                           TotalOrders = ordersByPaid.Count()
                       };

            return list;

        }

        public IQueryable<Feature9ViewModel> GetNoOfOrdersForProducts()
        {
            /*var list = from order in Context.Orders
                       group order by order.Product into orderByProduct
                       select new Feature9ViewModel()
                       {
                           Product = orderByProduct.Key,
                           TotalOrdersForProduct = orderByProduct.Count()
                       };
            */

            var list = from product in Context.Products
                       orderby product.Orders.Count descending
                       select new Feature9ViewModel()
                       {
                           Product = product,
                           TotalOrdersForProduct = product.Orders.Count
                       };

            return list;


        }


        public IQueryable<CategorySummaryViewModel> GetTotalOrdersPerCategory()
        {
            /* var list =
                        from product in Context.Products

                        group product by product.Category into categoryGroup
                        select new CategorySummaryViewModel()
                        {
                            Category = categoryGroup.Key,
                            TotalNoOfProducts = categoryGroup.Key.Products.Count(x => x.Orders.Count > 0)
                        }; 

             */

            var list = from category in Context.Categories
                       group category by category into categoryGroup
                       select new CategorySummaryViewModel()
                       {
                           Category = categoryGroup.Key,
                           TotalNoOfProducts = categoryGroup.Key.Products.Count(x => x.Orders.Count > 0)
                       };

            return list;


           /* var list =
                     from category in Context.Categories
                     from product in category.Products
                     select new CategorySummaryViewModel()
                     {
                         Category = category,
                         TotalNoOfProducts = product.Orders.Count //total no of orders
                     };*/
            return list;
                      
        }


        public IQueryable<Feature11ViewModel> GetTotalSumOfOrdersPerCategory()
        {
            

            var list = from category in Context.Categories
                       group category by category into categoryGroup
                       select new Feature11ViewModel()
                       {
                           Category = categoryGroup.Key,
                           TotalOrdersPerCategory = categoryGroup.Key.Products.Count(x => x.Orders.Count > 0),
                           TotalPriceForAllOrdersInCategory =  
                            categoryGroup.Key.Products.Where(x => x.Orders.Count > 0).Sum(x=> x.Price)
                            == null? 0
                            : 
                           categoryGroup.Key.Products.Where(x => x.Orders.Count > 0).ToList().Sum(x => x.Orders.Sum(y=>y.Qty)* x.Price) 
                       };

            return list; 

        }
    }
}
