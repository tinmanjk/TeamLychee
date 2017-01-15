namespace PostingServices.Core.Models.Shipments
{
    using System;
    using PostingServices.People;
    using PostingServices.PostOffices;
    using PostingServices.Core.Models.Shipment.Abstract;
    using Infrastructure.Enumerations;
    using System.Text;

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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("Type: Letter\n"));
            result.Append(String.Format("Paper size: {0}\n", this.paperSize));
            result.Append(String.Format("Letter text: {0}\n", this.text));

            return result.ToString() + base.ToString();
        }
    }
}
