using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.Shipments;
using PostingServices.Orders;
using PostingServices.OrderContainer;

namespace PostingServices.People
{
    public class Sender : Person
    {
        public Sender(string name, string phoneNumber) : base(name,phoneNumber)
        {
            //might add some fields,properties etc
        }

        // methods
        public void SendShipment(Shipment shipment)
        {
            Order orderToBeSent = new Order(shipment);
            OrdersContainer.AddOrder(orderToBeSent);
        }
    }
}
