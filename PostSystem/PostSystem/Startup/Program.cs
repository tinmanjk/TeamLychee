using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            //IOrder order = new Order();
            IOrder newOrder = new Order(new Customer(),new Customer(),new Employee(),new Parcel(new Dimensions(100, 200, 150, 2), false), new Destination(),false);
            IOrder newOrder2 = new Order(new Customer(), new Customer(), new Employee(), new Parcel(new Dimensions(100, 200, 150, 2), false), new Destination(), false);
            IOrder newOrder23 = new Order(new Customer(), new Customer(), new Employee(), new Parcel(new Dimensions(100, 200, 150, 2), false), new Destination(), false);
            Price cost = new Price();
            cost.Distance = Distance.Burgas;
            cost.TypeOfPackage = new Parcel(new Dimensions(100,10,10,2),false);

            //Console.WriteLine(cost.GetPrice());
            //Console.WriteLine(newOrder.Id);
            //Console.WriteLine(order.Id);
            //Console.WriteLine(newOrder2.Id);
            //Console.WriteLine(newOrder23.Id);

            OrderList.Display();


        }
    }
}
