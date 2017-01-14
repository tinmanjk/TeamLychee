using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public abstract class Package
    {
        private Dimensions dimensions;
        private bool fragile;
        private double size;

        public Package(Dimensions dimensions, bool fragile)
        {
            this.Dimensions = dimensions;
            this.Fragile = fragile;
        }

        public Dimensions Dimensions
        {
            get
            {
                return this.dimensions;
            }
            set
            {
                this.dimensions = value;
            }
        }
        public bool Fragile
        {
            get
            {
                return this.fragile;
            }
            set
            {
                this.fragile = value;
            }
        }
        public double Size
        {
            get { return this.dimensions.CalculateSize(); }
        }
    }
}
