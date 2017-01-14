using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    static class OrderList
    {     
            static List<Order> orderList;

            static OrderList()
            {
            orderList = new List<Order>();
            }

            public static void AddOrder(Order order)
            {
            orderList.Add(order);
            }
        public static void Display()
        {
            foreach (var value in orderList)
            {
                Console.WriteLine(String.Format("Package ID:{0} | Package dimensions: {1} ", value.Id, value.PackageType.Dimensions.ShowDimensions()));
            }
        }
    }
}
