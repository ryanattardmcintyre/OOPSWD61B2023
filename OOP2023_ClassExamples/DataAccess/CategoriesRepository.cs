using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoriesRepository: MyConnection
    {
        public CategoriesRepository():base() { }

        public IQueryable<Category> GetCategories()
        { return Context.Categories; }


        /*
         *   Category      No. Of Items
         *   
         *   Peripherals      2
         *   Mobiles          1
         * 
         * 
         */ 
        public IQueryable<CategorySummaryViewModel> GetCategoriesSummaries()
        {

            //approach 1
             var list = from category in Context.Categories
                        select new CategorySummaryViewModel()
                        {
                            Category = category,
                            TotalNoOfProducts = category.Products.Count()
                        };


            //approach 2 - issue: if a category has no products, it won't be displayed
            /*var list = from product in Context.Products
                       group product by product.Category into newGroup
                       select new CategorySummaryViewModel()
                       {
                           Category = newGroup.Key,
                           TotalNoOfProducts = newGroup.Count()
                       };

           

            //approach 3 - issue: same as approach 2 but coded differently
            var list2 = from product in Context.Products
                       join category in Context.Categories
                       on product.CategoryFk equals category.Id
                       group product by category into newGroup
                       select new CategorySummaryViewModel()
                       {
                           Category = newGroup.Key,
                           TotalNoOfProducts = newGroup.Count()
                       };
 */
            return list ;

        }



    }
}
