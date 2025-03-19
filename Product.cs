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
            AddProducts();
        }

        public Product(string productName, string productCategory, int productPrice)
        {
            productName = this.ProductName;
            productCategory = this.ProductCategory;
            productPrice = this.ProductPrice;
        }

        //Hårddata produktlista
        public void AddProducts()
        {
            var produkt1 = new Product() { ProductName = "Fancy", ProductCategory = "Kjol", ProductPrice = 399 };

            var produkt2 = new Product() { ProductName = "Doolittle", ProductCategory = "Kjol", ProductPrice = 199 };

            var produkt3 = new Product() { ProductName = "Linda", ProductCategory = "Skjorta", ProductPrice = 299 };

            var produkt4 = new Product() { ProductName = "Rolig", ProductCategory = "T-Shirt", ProductPrice = 99 };

            var produkt5 = new Product() { ProductName = "RoligARE", ProductCategory = "T-Shirt", ProductPrice = 199 };
        }
    }
    //OPT: Change price of product method can be added here
    //OPT: Method to handle amount of products in inventory can be added here
    //OPT: Method to show all products in inventory can be added here
}
