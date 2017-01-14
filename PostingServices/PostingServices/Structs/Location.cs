using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Structs
{
    public struct Location
    {
        double xCoord;
        double yCoord;

        public Location(double x, double y)
        {
            this.xCoord = x;
            this.yCoord = y;
        }
    }
}
