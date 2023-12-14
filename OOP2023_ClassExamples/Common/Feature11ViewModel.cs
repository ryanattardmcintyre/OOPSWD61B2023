using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Feature11ViewModel
    {
        public Category Category { get; set; }
        public int TotalOrdersPerCategory { get; set; }

        public decimal TotalPriceForAllOrdersInCategory { get; set; }
    }
}
