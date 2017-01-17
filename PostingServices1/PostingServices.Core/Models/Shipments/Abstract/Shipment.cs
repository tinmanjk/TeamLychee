using System;
using System.Text;
using PostingServices.Core.Contracts;
using PostingServices.Core.Models.People;
using PostingServices.Core.Models.PostOffices;
using PostingServices.Core.Infrastructure.Enumerations;
using PostingServices.Core.Infrastructure.Constants;


namespace PostingServices.Core.Models.Shipments
{
    public abstract class Shipment : IShipment
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

        public PostOffice OfficeSentFrom
        {
            get
            {
                return this.officeSentFrom;
            }
            private set
            {
                this.officeSentFrom = value;
            }
        }

        public PostOffice OfficeSentTo
        {
            get
            {
                return this.officeSentTo;
            }
            private set
            {
                this.officeSentTo = value;
            }
        }

        public Sender Sender
        {
            get { return this.sender; }
        }

        public Receiver Receiver
        {
            get { return this.receiver; }
        }

        //constructors

        public Shipment(Sender sender, Receiver receiver, PostOffice sentFrom, PostOffice sentTo, DeliveryType deliveryType)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.officeSentFrom = sentFrom;
            this.officeSentTo = sentTo;
            this.deliveryType = deliveryType;
            this.dateSent = CurrentTime.timewalker.GetCurrentTime();
        }

        /*public Shipment(Sender sender, Receiver receiver, PostOffice sentFrom, PostOffice sentTo, DeliveryType deliveryType, DateTime sentOn)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.officeSentFrom = sentFrom;
            this.officeSentTo = sentTo;
            this.deliveryType = deliveryType;
            this.dateSent = sentOn;
        }   //custom defined dateTime*/

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("*Sender:\n{0}\n", this.sender));
            result.Append(String.Format("*Receiver:\n{0}\n", this.receiver));
            result.Append(String.Format("*Office sent from:\n{0}\n", this.OfficeSentFrom));
            result.Append(String.Format("*Office sent to:\n{0}\n", this.OfficeSentTo));
            result.Append(String.Format("*Delivery type:\n{0}\n", this.deliveryType));
            result.Append(String.Format("*Sent on:\n{0}\n", this.DateSent));

            return result.ToString();
        }
    }
}
