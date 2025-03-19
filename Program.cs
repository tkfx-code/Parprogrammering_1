namespace Parprogrammering_1
{
    /*
    Skapa en databas med hjälp av “code first”-approach, som ska hjälpa en e-handel.
    Ni behöver skapa klasser för:
    Kunder
    Order
    OrderRader
    Produkter
    Tabellerna ska vara kopplade i den ordningen som de står ovan. Tänk på att det kan vara 1 till många relationer. 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add hard data
            //Create database
            var dbCtx = new MyDbCtx();
            dbCtx.SaveChanges();
            //Add Customers from AddCustomers() in Customer.cs
            //Add Orders from AddOrders() method
            //Run LINQ Printing method to show table
            
            //Save changes to database
        }

        public void AddOrders(var dbCtx)
        {
            var order1 = new CustomerOrder()
            {
                ThisCustomer = dbCtx.Customers.First(x => x.FirstName == "Anna")
            };
            dbCtx.Add(order1);
            dbCtx.SaveChanges();

            var orderItem1 = new OrderRow()
            {
                ThisOrder = order1,
                NumberOfProducts = 3,
                ThisProduct = dbCtx.Products.First(p=>p.ProductName.StartsWith("Fancy"))
            };
            var orderItem2 = new OrderRow()
            {
                ThisOrder = order1,
                NumberOfProducts = 1,
                ThisProduct = dbCtx.Products.First(p => p.ProductName.StartsWith("Linda"))
            };
            dbCtx.Add(orderItem1);
            dbCtx.Add(orderItem2);
            dbCtx.SaveChanges();
            //Run CalculateTotalRow method in OrderRow.cs?

            var order2 = new CustomerOrder()
            {
                ThisCustomer = dbCtx.Customer.First(x => x.FirstName == "Bengt")
            };
            dbCtx.Add(order2);
            dbCtx.SaveChanges();

            var orderItem3 = new OrderRow()
            {
                ThisOrder = order2,
                NumberOfProducts = 2,
                ThisProduct = dbCtx.Products.First(x => x.ProductName.StartsWith("Rolig"))
            };
            var orderItem4 = new OrderRow()
            {
                ThisOrder = order2,
                NumberOfProducts = 1,
                ThisProduct = dbCtx.Products.First(x => x.ProductName.StartsWith("RoligARE"))
            };

            //Run CalculateTotalRow method in OrderRow.cs?
            dbCtx.Add(orderItem3);
            dbCtx.Add(orderItem4);
            dbCtx.SaveChanges();
        }
        

    /* ADD WHEN READY FOR DBO 
    -- Add Connection String property
    -- I slutet skapa en databas, add migration och update
    */

    }
}




/* OPTIONAL:
* FUTURE UPGRADES TO PROGRAM:
* //Show menu: Add test data, add customer, add order, change price of product, products sold etc
  //Extras: Menu add to/change order, change customer info
  //Menu: LINQ Printing : Customer register (ID + Customer info), Customer + their orders, an order containing/order date
  //Skapa bara kundregister - save.Changes();

* METOD Show menu
* METOD Hantera input meny
* 
* METOD Testdata - eventuellt metod rensa testdata/clear at start up/kollar efter dubletter först?
* 
* METOD Ändra kontakt 
* METOD printing
*
* METOD Skapa kontakt
* public void CreateContact()
* cw("Ange förnamn")
* readline firstName
* 
* METOD hanterar add Customer: 
* void X (strings fName, lName, contact)
* dbCtx.Add(new Customer()
* { FirstName = fName,
* LastName = lName,
* Contact = contact
* });
* dbCtx.SaveChanges();
*/