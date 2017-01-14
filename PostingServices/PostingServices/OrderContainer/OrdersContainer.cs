using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.Orders;

namespace PostingServices.OrderContainer
{
    public class OrdersContainer
    {
        //in case orders are kept in a file(table,sql,txt etc)
        //might add method to load them into the private list

        //fields
        private List<Order> orders;

        //properties
        public List<Order> Orders
        {
            get
            {
                return new List<Order>(this.orders);
            }
            private set
            {
                this.orders = value;
            }
        }

        //constructors
        public OrdersContainer()
        {
            this.Orders = new List<Order>();
        }

        //methods
        public void AddOrder(Order order)
        {
            this.orders.Add(order);
        }

        public void RemoveOrder(Order order)
        {
            this.orders.Remove(order);
        }
    }
}
