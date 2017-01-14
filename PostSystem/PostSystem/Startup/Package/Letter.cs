using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public class Letter : Package
    {
        public Letter(double weight, double width, double height, double length, bool fragile) :
            base(weight, width, height, length, fragile)
        {
        }
    }
}
