using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    
    internal class Product
    {
        private string productID;
        private string productName;
        private decimal price;

        private ProductCategory category;


        public Product(string productID, string productName, decimal price, ProductCategory category)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price;
            this.category = category;
        }

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal Price { get => price; set => price = value; }
        public ProductCategory Category { get => category; set => category = value; }

        public override string ToString()
        {
            return $"ProductID: {productID}, ProductName: {productName}, Price: {price}, Category: [{category}]";
        }

    }
}
