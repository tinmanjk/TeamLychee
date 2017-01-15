namespace PostingServices.People
{
    using PostingServices.Orders;
    using Core.Models.Shipment.Abstract;

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
