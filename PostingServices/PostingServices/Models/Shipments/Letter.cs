namespace PostingServices.Core.Models.Shipments
{

    using PostingServices.People;
    using PostingServices.PostOffices;
    using PostingServices.Core.Models.Shipment.Abstract;
    using Infrastructure.Enumerations;

    public class Letter : Shipment
    {
        private PaperSize a4;
        private PaperSize paperSize;
        private string text;

        public Letter(Sender sender, Receiver receiver, PostOffice sentFrom, PostOffice sentTo, DeliveryType deliveryType) : base(sender, receiver, sentFrom, sentTo, deliveryType)
        {
            this.a4 = a4;
            this.text = text;
        }

        //properties

        //constructors
        public Letter(Sender sender, Receiver receiver, PostOffice sentFrom, PostOffice sentTo, DeliveryType deliveryType, PaperSize paperSize, string text)
            : base(sender, receiver, sentFrom, sentTo, deliveryType)
        {
            this.paperSize = paperSize;
            this.text = text;
        }
    }
}
