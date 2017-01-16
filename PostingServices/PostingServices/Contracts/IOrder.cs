using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core
{
    interface IOrder
    {
        DateTime DeliveryDate{get; }


        string ToString();
        DateTime CalculateDeliveryDate();
        void ShipmentDelivered();
    }
}
