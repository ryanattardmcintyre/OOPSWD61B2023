using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataAccess
{
    public class MyConnection
    {
        public ShoppingCartOOPEntities Context { get; set; } 
        //property representing the auto-generated class which allows me to access the database

        public MyConnection() {
            Context = new ShoppingCartOOPEntities();
        }
    }
}
