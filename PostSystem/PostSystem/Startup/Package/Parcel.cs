using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public class Parcel : Package
    {
        private double Width;

        private double Height;

        private double Length;

        public Parcel(Dimensions dimensions, bool fragile) 
            : base(dimensions, fragile)
        {
        }
    }
}
