using RestaurantManager.Utils;
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
        public List<OrderItem> Items { get => items;
            
            
            set 
            {

                if (value == null)
                {
                    items = new List<OrderItem>();
                }
                else
                {
                    // Remove zero-quantity items automatically
                    items = value.Where(i => i.Quantity > 0).ToList();
                }
            } 
        }
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


    public static class OrderList
    {
        public static List<Order> Orders { get; set; } = new List<Order>();

        public static List<Order> InitDefaultOrderList()
        {
            Orders = new List<Order>();
            FileUtils.SaveToJson(Constant.ORDER_DATA_FILE, Orders);
            return Orders;
        }

        public static Order CreateNextOrder(int tbID, string userID)
        {
            int orderID = IDStorage.GetNextOrderID();
            DateTime createAt = DateTime.Now;
            return new Order(orderID, tbID, createAt, null, false, userID);
        }


        public static bool InitDataList()
        {
            try 
            {
                if (!File.Exists(Constant.ORDER_DATA_FILE))
                {
                    Orders = InitDefaultOrderList();
                    return false;

                }
                Orders = FileUtils.LoadFromJson<List<Order>>(Constant.ORDER_DATA_FILE);
                if (Orders == null || Orders.Count == 0)
                {
                    Orders = InitDefaultOrderList();
                    return false;

                }
                return true;
            }
            catch(Exception e) 
            {
                MessageBox.Show($"There an error loading Order list. \nA default list will be create.\n {e.Message}", "Error", MessageBoxButtons.OK);
                Orders = InitDefaultOrderList();
                return false;
            
            }


            
        }

        public static Order GetOrderByID(int id)
        {
            if (id == -1) return null;
            foreach (var order in Orders)
            {
                if (order.OrderID == id)
                {
                    return order;
                }

            }
            return null;

        }


        public static bool AddOrder(Order order)
        {
            try 
            {
                Orders.Add(order);
                FileUtils.SaveToJson(Constant.ORDER_DATA_FILE, Orders);
                return true;

            
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error adding order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            
            }

        }

        public static bool DeleteOrder(Order order)
        {
            try 
            {
                Orders.Remove(order);
                FileUtils.SaveToJson(Constant.ORDER_DATA_FILE, Orders);
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error delete order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateOrder(Order order)
        {
            try
            {
                var existedOrder = GetOrderByID(order.OrderID);
                if (existedOrder != null)
                {
                   
                    existedOrder.TableID= order.TableID;
                    existedOrder.IsPaid = order.IsPaid;
                    existedOrder.Items= order.Items;
                    FileUtils.SaveToJson(Constant.ORDER_DATA_FILE,Orders); 
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error update order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static int GetTotalPriceOfOrder(int id)
        {
            int total = 0;
            foreach (var order in OrderList.Orders)
            {
                if (order.OrderID == id)
                {
                    foreach (var item in order.Items)
                    {
                        total += item.Quantity * item.UnitPrice;
                    }
                }
            }
            return total;
        }
        public static int GetTotalRevenueFromTo(DateTime from, DateTime to)
        {
            int total = 0;

            foreach (var order in Orders)
            {
                if (order.IsPaid && order.CreateAt >= from && order.CreateAt <= to)
                {
                    foreach (var item in order.Items)
                    {
                        total += item.Quantity * item.UnitPrice;
                    }
                }
            }

            return total;
        }


       

        
       


    }
}
