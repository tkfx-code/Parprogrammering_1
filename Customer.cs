using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_1
{
    //Customer info, collects customer orders
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public CustomerOrder? ThisCustomerOrder { get; set; }

        public Customer() {}
        public override string ToString()
        {
            return $"Förnamn: {FirstName}\n" +
                $"Efternamn: {LastName}\n" +
                $"Adress: {Address}\n";
        }

    }
    //ToString method print this customers orders - Order ID, date and amount of products?
}
