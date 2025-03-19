using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_1
{
    //OrderRow connects to a full order, shows info about specific ordered item
    //OPT: Clear OrderRowID After adding to order?
    internal class OrderRow
    {
        public int OrderRowId { get; set; }
        public Product? ThisProduct { get; set; }
        public CustomerOrder? ThisOrder { get; set; }
        public double UnitPrice { get; set; }
        public int NumberOfProducts { get; set; }
        public double TotalRowPrice { get; set; }


        public OrderRow()
        {
            
        }

        public void CalculateTotalRowPrice()
        {
            UnitPrice = ThisProduct.ProductPrice;
            TotalRowPrice = UnitPrice*NumberOfProducts;
        }
    }

}
