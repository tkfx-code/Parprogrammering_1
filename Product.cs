using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering_1
{
    //Product info
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = "";
        public string ProductCategory { get; set; } = "";
        public int ProductPrice {  get; set; }
        public Product()
        {
            
        }

        public Product(string productName, string productCategory, int productPrice)
        {
            productName = this.ProductName;
            productCategory = this.ProductCategory;
            productPrice = this.ProductPrice;
        }

        //Hårddata produktlista
        public static void AddProducts(MyDbCtx ctx) { 
        
            ctx.Add(new Product() { ProductName = "Fancy", ProductCategory = "Kjol", ProductPrice = 399 });
            ctx.Add(new Product() { ProductName = "Doolittle", ProductCategory = "Kjol", ProductPrice = 199 });
            ctx.Add(new Product() { ProductName = "Linda", ProductCategory = "Skjorta", ProductPrice = 299 });
            ctx.Add(new Product() { ProductName = "Rolig", ProductCategory = "T-Shirt", ProductPrice = 99 });
            ctx.Add(new Product() { ProductName = "RoligARE", ProductCategory = "T-Shirt", ProductPrice = 199 });
            ctx.SaveChanges();
        }
    }
    //OPT: Change price of product method can be added here
    //OPT: Method to handle amount of products in inventory can be added here
    //OPT: Method to show all products in inventory can be added here
}
