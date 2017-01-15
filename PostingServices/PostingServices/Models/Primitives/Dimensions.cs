namespace PostingServices.Primitives.Dimensions
{
    using System;
    using System.Text;

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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Width: {0}\n", this.width);
            result.AppendFormat("Height: {0}\n", this.height);
            result.AppendFormat("Length: {0}\n", this.length);
            result.AppendFormat("Weight: {0}\n", this.weight);

            return result.ToString();
        }
    }
}
