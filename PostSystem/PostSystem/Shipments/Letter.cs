using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSystem.Structs;
using PostSystem.People;
using PostSystem.PostOffices;
using PostSystem.Enums;

namespace PostSystem.Shipments
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
