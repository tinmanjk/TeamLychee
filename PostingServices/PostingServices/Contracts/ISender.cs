using PostingServices.Core.Models.Shipment.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core
{
    interface ISender
    {

        void SendShipment(Shipment shipment);
    }
}
