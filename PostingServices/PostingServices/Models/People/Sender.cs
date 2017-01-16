namespace PostingServices.People
{
    using PostingServices.Orders;
    using Core.Models.Shipment.Abstract;

    public class Sender : Person
    {
        public Sender(string firstname, string lastname, string phoneNumber)
            : base(firstname, lastname, phoneNumber)
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
