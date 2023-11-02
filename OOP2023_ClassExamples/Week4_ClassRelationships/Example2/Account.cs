using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships.Example2
{
    /*
     * Composition: Account to person
     * 
     * Aggregation: Bank to Account
     * 
     * Association: Bank to Person,Bank to Guid
     */ 

    public class Account
    {
        public Account(Person p) {

            Person = p;
        }

        public Person Person { get; set; }  

        public string IBAN { get; set; }
        public string IdCard { get; set; }

        protected double balance;
        //note: protected allows the field to be inherited as well unlike private fields;
        //but it does not allow it to be accessed from other classes other than the non-inherited ones
        public double Balance
        {
            get
            {
                return balance;
            }
        }

        public DateTime OpenedDate { get; set; }
        public DateTime? ClosedDate { get; set; }

        public bool Active { get; set; }

        public virtual double Deposit(double amount)
        {//if (amount <= 10) throw new Exception("not allowed");
            balance += amount;
            return Balance;

        }
    }
}
