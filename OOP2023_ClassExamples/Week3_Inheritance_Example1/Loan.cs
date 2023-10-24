using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Inheritance_Example1
{
    public class Loan: Account
    {
        public double Interest { get; set; }
        public int Months { get; set; }

        public double InitialLoanAmount { get; set; }

        public double CalculateMonthlyRepayment()
        {
            return (((Interest / 100) * Balance) / 12) + (InitialLoanAmount/Months) ;
        }

        public override double Deposit(double amount) 
        {
            if (InitialLoanAmount == 0)
            {
                InitialLoanAmount = Math.Abs(amount) * -1;  
                balance= InitialLoanAmount;
            }
            else
            {
                if (amount < CalculateMonthlyRepayment())
                {
                    throw new Exception("Amount is less than the expected monthly repayment");
                }
                else
                {
                    balance += amount;
                }
            }

            return balance;
        }
    }
}
