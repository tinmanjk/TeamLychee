using System.Text;
using System;
using PostingServices.Core.Contracts;
using PostingServices.Core.Models.Primitives;
using PostingServices.Core.Models.People;
using PostingServices.Core.Infrastructure.Enumerations;
using PostingServices.Core.Models.PostOffices;


namespace PostingServices.Core.Models.Shipments
{
    public class Parcel : Shipment, IParcel
    {
        private Dimensions dimensions;
        private string content;

        //properties

        public Dimensions Dimensions
        {
            get { return this.dimensions; }
            private set { this.dimensions = value; }
        }
        public string Content
        {
            get { return this.content; }
            private set { this.content = value; }

        }

        //constructors
        public Parcel(Sender sender, Receiver receiver, PostOffice sentFrom, PostOffice sentTo, DeliveryType deliveryType, Dimensions dimensions, string content)
            : base(sender, receiver, sentFrom, sentTo, deliveryType)
        {
            this.Dimensions = dimensions;
            this.Content = content;
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
