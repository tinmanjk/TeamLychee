namespace PostingServices.PostOffices
{
    using PostingServices.Primitives.Location;
    using Infrastructure.Constants;
    using System.Device.Location;

    public class PostOffice
    {
        private string name;
        private GeoCoordinate location;

        //properties

        //constructor
        public PostOffice(string name, GeoCoordinate location)
        {
            this.name = name;
            this.location = location;
        }
    }
}
