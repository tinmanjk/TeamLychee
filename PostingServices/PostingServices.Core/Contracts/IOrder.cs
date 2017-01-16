using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core.Contracts
{
    interface IOrder
    {
        DateTime DeliveryDate { get; }


        string ToString();
        DateTime CalculateDeliveryDate();
        void ShipmentDelivered();
    }
}
