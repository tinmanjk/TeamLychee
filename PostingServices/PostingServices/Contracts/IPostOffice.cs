using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core
{
    interface IPostOffice
    {
        GeoCoordinate Location { get; }
        string Name { get; }

        string ToString();


    }
}
