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

        public Parcel(double weight, double width, double height, double length, bool fragile) 
            : base(weight, width, height, length, fragile)
        {
        }
    }
}
