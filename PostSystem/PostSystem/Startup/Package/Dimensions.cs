using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public struct Dimensions
    {
        private double weight;
        private double width;
        private double height;
        private double length;

        public Dimensions(double width, double height, double length, double weight)
            :this()
        {
            this.Height = height;
            this.Width = width;
            this.Length = length;
            this.Weight = weight;
        } 

        public double Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                this.weight = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                this.height = value;
            }
        }
        public double Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                this.length = value;
            }
        }

        public double CalculateSize()
        {
            return this.Width * this.Height * this.Length;
        }
        public string ShowDimensions()
        {
            StringBuilder sb = new StringBuilder()
                                   .AppendFormat("Width:{0}cm, Height:{1}cm, Length:{2}cm, {3}kg", this.Width, this.Height, this.Length, this.Weight);

            return sb.ToString();
        }

    }
}
