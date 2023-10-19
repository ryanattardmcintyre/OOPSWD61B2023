using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Inheritance_Example1
{
    public class Savings: Current
    {
        public double InterestRate { get; set; }

        public double CalculateInterest() {
            return (InterestRate / 100) * Balance;
        
        }

        public double CalculateTax(double taxRate) {
            double interest = CalculateInterest();
            return (taxRate / 100) * interest;
        
        }
    }
}
