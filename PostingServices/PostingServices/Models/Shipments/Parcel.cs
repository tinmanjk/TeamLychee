namespace PostingServices.Core.Models.Shipments
{
    using PostingServices.People;
    using PostingServices.PostOffices;
    using PostingServices.Core.Models.Shipment.Abstract;
    using Primitives.Dimensions;
    using Infrastructure.Enumerations;

    class Parcel : Shipment
    {
        private Dimensions dimensions;
        private string content;

        //properties

        //constructors
        public Parcel(Sender sender, Receiver receiver, PostOffice sentFrom, PostOffice sentTo, DeliveryType deliveryType, Dimensions dimensions, string content)
            :base(sender, receiver, sentFrom, sentTo, deliveryType)
        {
            this.dimensions = dimensions;
            this.content = content;
        }

        
    }
}
