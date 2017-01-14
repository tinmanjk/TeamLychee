using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public class Letter : Package
    {
        public Letter(Dimensions dimensions, bool fragile) :
            base(dimensions, fragile)
        {
        }
    }
}
