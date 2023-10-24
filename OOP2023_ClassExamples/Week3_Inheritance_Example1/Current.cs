using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Inheritance_Example1
{
    public class Current : Account
    {
        public Current() { }

        public Current(string iBAN, string idCard, double balance, DateTime? openedDate,
            int chequeBookNo)
            :base(iBAN, idCard, balance, openedDate)
        {
            ChequeBookNo = chequeBookNo;
        }

        public int ChequeBookNo { get; set; }

        public double Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                throw new Exception("Insufficient balance");
            }
            return balance;
        }

        public void Transfer(Account destinationAccount, double amount)
        {
            Withdraw(amount);
            destinationAccount.Deposit(amount);
        
        }
    }
}
