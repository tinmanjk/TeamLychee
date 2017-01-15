namespace PostingServices.Primitives.Dimensions
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
