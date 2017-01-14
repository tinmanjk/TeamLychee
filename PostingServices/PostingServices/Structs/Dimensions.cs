using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Structs
{
    public struct Dimensions
    {
        double width;
        double height;
        double length;
        double weight;

        public Dimensions(double width, double height, double length, double weight)
        {
            this.width = width;
            this.height = height;
            this.length = length;
            this.weight = weight;
        }
    }
}
