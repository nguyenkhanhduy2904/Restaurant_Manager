using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    public class Order
    {
        private int orderID;
        private int tableID;
        private DateTime createAt;
        private List<OrderItem> items;
        private bool isPaid;
        private string orderedByUserID;

        public int OrderID { get => orderID; set => orderID = value; }
        public int TableID { get => tableID; set => tableID = value; }
        public DateTime CreateAt { get => createAt; set => createAt = value; }
        public List<OrderItem> Items { get => items; set => items = value; }
        public bool IsPaid { get => isPaid; set => isPaid = value; }
        public string OrderedByUserID { get => orderedByUserID; set => orderedByUserID = value; }

        public Order(int orderID, int tableID, DateTime createAt, List<OrderItem> items, bool isPaid, string orderedByUserID)
        {
            this.orderID = orderID;
            this.tableID = tableID;
            this.createAt = createAt;
            this.items = items;
            this.isPaid = isPaid;
            this.orderedByUserID = orderedByUserID;
        }
    }
}
