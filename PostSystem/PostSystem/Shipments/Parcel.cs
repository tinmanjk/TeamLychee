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
