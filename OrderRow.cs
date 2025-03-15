using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_1
{
    //Collect products into a row of an order, with how many products are ordered
    //Connect OrderRows to an Order to be able to group together in dbo
    internal class OrderRow
    {
        public int OrderRowId { get; set; }
        public Product? ThisProduct { get; set; }
        public CustomerOrder? ThisOrder { get; set; }
        public int NumberOfProducts { get; set; }
    }

}
