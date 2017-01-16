using Infrastructure.Enumerations;
using PostingServices.PostOffices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core
{
    interface IShipment
    {
        DateTime DateSent { get; }
        DeliveryType DeliveryType { get; }
        PostOffice OfficeSentFrom { get; }
        PostOffice OfficeSentTo { get; }
        string ToString();
    }
}
