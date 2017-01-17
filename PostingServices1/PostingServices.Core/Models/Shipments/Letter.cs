using System;
using System.Text;
using PostingServices.Core.Contracts;
using PostingServices.Core.Infrastructure.Enumerations;
using PostingServices.Core.Models.People;
using PostingServices.Core.Models.PostOffices;

namespace PostingServices.Core.Models.Shipments
{


    public class Letter : Shipment, ILetter
    {
        //private PaperSize a4;
        private PaperSize paperSize;
        private string text;

        //public Letter(Sender sender, Receiver receiver, PostOffice sentFrom, PostOffice sentTo, DeliveryType deliveryType) : base(sender, receiver, sentFrom, sentTo, deliveryType)
        //{
        //    this.a4 = a4;
        //    this.text = text;
        //}

        public PaperSize PaperSize
        {
            get { return this.paperSize; }
            private set { }
        }
        public string Text
        {
            get { return this.text; }
            private set { this.text = value; }
        }

        //constructors
        public Letter(Sender sender, Receiver receiver, PostOffice sentFrom, PostOffice sentTo, DeliveryType deliveryType, PaperSize paperSize, string text)
            : base(sender, receiver, sentFrom, sentTo, deliveryType)
        {
            this.PaperSize = paperSize;
            this.Text = text;
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
