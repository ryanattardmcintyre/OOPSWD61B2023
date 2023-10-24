using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Inheritance_Example1
{
    public class Account
    {
        //note: when you are OVERLOADING the constructor/method; that is STATIC POLYMORPHISM
        //note: overloading is when you can create a "copy" of the same constructor/method within the same class,
        //      however it must have different parameters

        //note: when you are OVERRIDING a method; that is DYNAMIC POLYMORPHISM
        //note: overriding is when you are strictly changing the method's implementation in a derived class

        public Account() { } //default constructor

        public Account(string iBAN, string idCard, double balance, DateTime? openedDate)
        {
            IBAN = iBAN;
            IdCard = idCard;
            this.balance = balance; //this - that refers to the instance on which you will be working/in which you will be storing the values
            if (openedDate == null)
            {
                OpenedDate = DateTime.Now;
            }
            else
                OpenedDate = openedDate.Value;

            ClosedDate = null;
            Active = true;
        }

        public string IBAN { get; set; }
        public string IdCard { get; set; }

        protected double balance; 
        //note: protected allows the field to be inherited as well unlike private fields;
        //but it does not allow it to be accessed from other classes other than the non-inherited ones
        public double Balance { get {
                return balance;
            } }

        public DateTime OpenedDate { get; set; }    
        public DateTime? ClosedDate { get; set;}

        public bool Active { get; set; }

        public virtual double Deposit(double amount)
        {//if (amount <= 10) throw new Exception("not allowed");
            balance += amount;
            return Balance;

        }
    }
}
