using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.Orders;

namespace PostingServices.OrderContainer
{
    public static class OrdersContainer
    {
        //in case orders are kept in a file(table,sql,txt etc)
        //might add method to load them into the private list

        //fields
        private static List<Order> orders = new List<Order>();

        //properties
        public static List<Order> Orders
        {
            get
            {
                return new List<Order>(orders);
            }
            private set
            {
                orders = value;
            }
        }

        //constructors

        //methods
        public static void AddOrder(Order order)
        {
            orders.Add(order);
        }
    }
}
