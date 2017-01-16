namespace PostingServices.PostOffices
{
    using PostingServices.Primitives.Location;
    using Infrastructure.Constants;
    using System.Device.Location;
    using System;
    using System.Text;
    using Core;
    public class PostOffice:IPostOffice
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
        public string Name
        {
            get { return this.name; }
            private set { }
        }
        //constructor
        public PostOffice(string name, GeoCoordinate location)
        {
            this.Name = name;
            this.Location = location;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Office name: {0}\n", this.name);
            return result.ToString();
        }
    }
}
