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
            
            //ContactsDbContext dbCtx = new ContactsDbContext();

            //Show menu: Add test data, add customer, add order, change price of product, products sold etc
            //Extras: Menu add to/change order, change customer info
            //Menu: LINQ Printing : Customer register (ID + Customer info), Customer + their orders, an order containing/order date
            //Skapa först kundregister - lista kunder + var dbcontext = new dbContext(); - save.Changes();


            //Arbeta bakifrån där man 
            //1. Lägger produkter i kundkorgen 
            //2. Kundkorgen lägger produkterna på orderrader
            //3. Orderradernna läggs in i en fullskalig order
            //4. Ordern kopplas till Kunden 



            //Save changes + clear
        }
        /* 
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
        * */
    }
}
 /* 
 * CustomerDbContext : DbContext
 * public DbSet<Customer> Customers
 * public DbSet<Product> Products
 * public DbSet<OrderRow> OrderRows
 * public DbSet<CustomerOrder> CustomerOrders
 *
 * private string connectionString
 * empty constructor
 * protected override onConfig, optionsbuilder.usesqlserver(connectionstring)
   -- I slutet skapa en databas, add migration och update
 * 
 * 
 * DbStart.cs ??
 * 
 */