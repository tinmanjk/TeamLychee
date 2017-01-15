namespace PostingServices.Core.Models.Shipments
{
    using PostingServices.People;
    using PostingServices.PostOffices;
    using PostingServices.Core.Models.Shipment.Abstract;
    using Primitives.Dimensions;
    using Infrastructure.Enumerations;
    using System.Text;
    using System;

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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Type: Parcel\n");
            result.AppendFormat("Dimensions: \n{0}\n", this.dimensions);
            result.AppendFormat("Content: {0}\n", this.content);

            return result.ToString() + base.ToString();
        }

    }
}
