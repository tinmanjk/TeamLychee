using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public abstract class Package
    {

        private double weight;
        private bool fragile;
        private double width;
        private double height;
        private double length;
        private double size;

        public Package(double weight, double width, double height, double length, bool fragile)
        {
            this.Height = height;
            this.Width = width;
            this.Length = length;
            this.Weight = weight;
            this.Fragile = fragile;

        }
        public double Weight
        {
            get; private set;
        }
        public double Width
        {
            get; private set;
        }
        public double Height
        {
            get; private set;
        }
        public double Length
        {
            get; private set;
        }
        public bool Fragile
        {
            get; private set;
        }
        public double Size
        {
            get { return this.Width * this.Height * this.Length; }
        }
    }
}
