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
            //Add customers
            Customer.AddCustomers(dbCtx);
            dbCtx.SaveChanges();
            //Add products
            Product.AddProducts(dbCtx);
            //Add Orders and order rows
            AddOrders(dbCtx);

            //Run LINQ Printing method to show table

            Console.WriteLine("Press 1 to Save and Quit program\n Press 2 to Clear table and Quit program");
            var choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    dbCtx.SaveChanges();
                    break;
                case 2:
                    dbCtx.RemoveAll();
                    break;
            }
            Environment.Exit(0);
        }

        public static void AddOrders(MyDbCtx dbCtx)
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
            //Add items to order and rows
            //Then calculate each rows total price
            order1.OrderRows.Add(orderItem1);
            orderItem1.CalculateTotalRowPrice();
            order1.OrderRows.Add(orderItem2);
            orderItem2.CalculateTotalRowPrice();
            //Calculate the total order value
            order1.CalculateOrderValue();

            dbCtx.SaveChanges();

            var order2 = new CustomerOrder()
            {
                ThisCustomer = dbCtx.Customers.First(x => x.FirstName == "Bengt")
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

            order2.OrderRows.Add(orderItem3);
            orderItem3.CalculateTotalRowPrice();
            order2.OrderRows.Add(orderItem4);
            orderItem4.CalculateTotalRowPrice();
            order2.CalculateOrderValue();

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