namespace PostingServices.Primitives.Location
{

    public struct Location
    {
        double xCoord;
        double yCoord;

        public Location(double x, double y)
        {
            this.xCoord = x;
            this.yCoord = y;
        }
    }
}
