using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_1
{
    //Collect OrderRows to put into a customers order, order owned by a Customer
    internal class CustomerOrder
    {
        public int CustomerOrderID { get; set; }
        public Customer? ThisCustomer { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public List<OrderRow> OrderRows { get; set; }
        public double OrderValue { get; set; }

        public CustomerOrder()
        {
            CalculateOrderValue();
        }

        //Calculate OrderValue by value of each OrderRow added together
        public void CalculateOrderValue()
        {
            double sum = 0;
            foreach (var row in OrderRows)
            {
                sum += row.TotalRowPrice;
            }
            OrderValue = sum;
        }

        //OPT: ToString Method to print entire order in its own neat Table can be added here
    }
}
