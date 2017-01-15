using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.People;
using PostingServices.Shipments;
using PostingServices.Addresses;
using PostingServices.PostOffices;
using PostingServices.Structs;
using PostingServices.Enums;
using PostingServices.OrderContainer;


namespace PostingServices
{
    class Program
    {
        static void Main()
        {
            // post offices are defined manually, can be kept in a file (might not be the best option)
            // new sender
            // new receiver
            // new shipment
            // use sender.Send(...) or PostOffice.Send(...)
            // 
            // what Send does is:
            // new Shipment(sender, receiver, sentFrom office, sentTo office, delivery type)
            // make a new Order(of the shipment)
            // add that order in the orders container
            // unique ID is displayed to the sender
            //
            // * can add functionalities:
            // - every time the program is started orders to check if they are later than DateTime.Now and mark themselves received
            // - track : enter the order ID, OrdersContainer searches in its list for the ID and displays information
            // - not sure how to add events
            // - interfaces for different classes which might contain the methods
            //
            // * can add a few more types of shipments in order to get the required number of classes/depth of inheritance
            // *         

            Sender sender = new Sender("Gosho Sender", "+359888888");
            Address receiverAddress = new Address("Sofia", "Gorno nanadolnishte", 10);
            Receiver receiver = new Receiver("Gosho", "+88888+", receiverAddress);

            PostOffice officeSofia = new PostOffice("HQ Sofia", new Location(0, 0));
            PostOffice officeBurgas = new PostOffice("HQ Burgas", new Location(400, 25));
            string text = "Hope this thing works";

            Shipment shipment = new Letter(sender, receiver, officeSofia, officeBurgas, DeliveryType.TheFlash, PaperSize.A4, text);
            sender.SendShipment(shipment);
            sender.SendShipment(shipment);

            Console.WriteLine("Orders:");
            foreach (var item in OrdersContainer.Orders)
            {
                Console.WriteLine(item);
            }
            
            //Shipment shipmentToSend = new Shipment(sender, receiver, ...)
        }
    }
}
