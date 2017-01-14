using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.People;
using PostingServices.PostOffices;
using PostingServices.Enums;

namespace PostingServices.Shipments
{
    public abstract class Shipment
    {
        private Sender sender;
        private Receiver receiver;
        private PostOffice officeSentFrom;
        private PostOffice officeSentTo;
        private DeliveryType deliveryType;
        private DateTime dateSent;

        // add properties
        public DateTime DateSent
        {
            get
            {
                return this.dateSent;
            }
        }

        public DeliveryType DeliveryType
        {
            get
            {
                return this.deliveryType;
            }
        }

        //constructors

        public Shipment(Sender sender, Receiver receiver, PostOffice sentFrom, PostOffice sentTo, DeliveryType deliveryType)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.officeSentFrom = sentFrom;
            this.officeSentTo = sentTo;
            this.deliveryType = deliveryType;
            this.dateSent = DateTime.Now;
        }
    }
}
