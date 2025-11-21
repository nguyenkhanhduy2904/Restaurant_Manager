using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    public class OrderItem
    {
        private string productID;
        private string productName;
        private int quantity;
        private int unitPrice;
        public int SumPrice => Quantity * UnitPrice;

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }

        

        public OrderItem(string productID, string productName, int quantity, int unitPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
           

        }


    }
}
