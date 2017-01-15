namespace PostingServices.PostOffices
{
    using PostingServices.Primitives.Location;
    using Infrastructure.Constants;
    using System.Device.Location;
    using System;
    using System.Text;

    public class PostOffice
    {
        private string name;
        private GeoCoordinate location;

        //properties
        public GeoCoordinate Location
        {
            get
            {
                return this.location;
            }
            private set
            {
                this.location = value;
            }
        }

        //constructor
        public PostOffice(string name, GeoCoordinate location)
        {
            this.name = name;
            this.location = location;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Office name: {0}\n", this.name);
            return result.ToString();
        }
    }
}
