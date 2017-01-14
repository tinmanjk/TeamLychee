using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.Structs;
using PostingServices.People;
using PostingServices.PostOffices;
using PostingServices.Enums;

namespace PostingServices.Shipments
{
    public class Letter : Shipment
    {
        private PaperSize paperSize;
        private string text;

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
