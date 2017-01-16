using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.Core.Infrastructure.Enumerations;
using PostingServices.Core.Models.PostOffices;

namespace PostingServices.Core.Contracts
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
