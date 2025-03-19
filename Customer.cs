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
        public virtual List<CustomerOrder> ThisCustomerOrder { get; set; }

        public Customer() 
        {
            AddCustomer();
        }
        public Customer(string firstName, string lastName, string address)
        {
            firstName = this.FirstName;
            lastName = this.LastName;
            lastName = this.Address;
        }

        //Hard data to add
        public void AddCustomer()
        {
            var customer1 = new Customer() { FirstName = "Anna", LastName = "Bengtsson", Address = "Gata 101" };
            var customer2 = new Customer() { FirstName = "Bengt", LastName = "Conradsson", Address = "Gata 103" };
            var customer3 = new Customer() { FirstName = "Conny", LastName = "Andersson", Address = "Gata 411" };
        }
        //Print customer
        public override string ToString()
        {
            return $"Förnamn: {FirstName}\n" +
                $"Efternamn: {LastName}\n" +
                $"Adress: {Address}\n";
        }

    }
    //ToString method print all orders from specific customer can be added here
        //Order ID, date and amount of products?
}
