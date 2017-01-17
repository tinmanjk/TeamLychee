using System.Collections.Generic;
using System.Linq;
using PostingServices.Core.Infrastructure.Constants;
using PostingServices.Core.Infrastructure.Utils;
using System;

namespace PostingServices.Core.Models.Orders
{
    public static class OrdersContainer
    {
        //in case orders are kept in a file(table,sql,txt etc)
        //might add method to load them into the private list
        private static TimeWalker publisher = CurrentTime.timewalker;   //publisher
        private static IList<Order> deliveredOrders = new List<Order>();


        //fields
        private static List<Order> orders = new List<Order>();

        //properties
        public static IList<Order> DeliveredOrders
        {
            get { return new List<Order>(deliveredOrders); }
        }
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
        static OrdersContainer()
        {
            publisher.TimeChanged += HandleTimeChange;
        }

        //methods
        public static void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public static IList<Order> GetDelivered()
        {
            var delivered = from order in OrdersContainer.orders
                            where order.DeliveryDate <= CurrentTime.timewalker.GetCurrentTime()
                            select order;

            return delivered.ToList();
        }

        public static void HandleTimeChange(object sender, EventArgs e)
        {
            OrdersContainer.deliveredOrders = GetDelivered();
        }

    }
}
