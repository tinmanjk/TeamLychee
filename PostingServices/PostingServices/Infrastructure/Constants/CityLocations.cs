using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace Infrastructure.Constants
{
    public static class CityLocations
    {
        public static readonly GeoCoordinate sofia = new GeoCoordinate(42.69751, 23.3241500);
        public static readonly GeoCoordinate plovdiv = new GeoCoordinate(42.1500000, 24.7500000);
        public static readonly GeoCoordinate burgas = new GeoCoordinate(42.5060600, 27.4678100);
        public static readonly GeoCoordinate varna = new GeoCoordinate(43.2166700, 27.9166700);
        public static readonly GeoCoordinate velikoTarnovo = new GeoCoordinate(43.0812400, 25.6290400);
        public static readonly GeoCoordinate ruse = new GeoCoordinate(43.8563900, 25.9708300);
    }
}
