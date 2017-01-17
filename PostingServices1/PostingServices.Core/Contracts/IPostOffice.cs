using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core.Contracts
{
    interface IPostOffice
    {
        GeoCoordinate Location { get; }
        string Name { get; }

        string ToString();


    }
}
