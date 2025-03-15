using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_1
{
    //Collect OrderRows to put into a customers order
    internal class CustomerOrder
    {
        public int CustomerOrderID { get; set; }
        public OrderRow? ThisOrderRow { get; set; }
        public DateTimeOffset OrderDate { get; set; }

        //Method to calculate order cost?
        //ToString Method to print entire order (with pricing?)
    }
}
