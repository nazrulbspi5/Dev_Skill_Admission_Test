using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class DataMerge
    {
        public List<Customer> CustomerList { get; set; }
        public List<Order> OrderList { get; set;}

        public List<(string customerName, List<string> productNames)> GetInfo()
        {
            var ans = from customer in CustomerList
                      join order in OrderList on customer.Id equals order.CustomerId
                      select (customer.Name, (from oo in order.Products select oo.Name).ToList());
            return ans.ToList();
        }
    }
}
