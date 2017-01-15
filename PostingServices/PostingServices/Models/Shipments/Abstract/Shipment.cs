namespace PostingServices.Core.Models.Shipment.Abstract
{

    using System;
    using PostingServices.People;
    using PostingServices.PostOffices;
    using Infrastructure.Enumerations;

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

        public Shipment(Sender sender, Receiver receiver, PostOffice sentFrom, PostOffice sentTo, DeliveryType deliveryType, DateTime sentOn)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.officeSentFrom = sentFrom;
            this.officeSentTo = sentTo;
            this.deliveryType = deliveryType;
            this.dateSent = sentOn;
        }   //custom defined dateTime
    }
}
