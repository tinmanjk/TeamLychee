using System.Device.Location;
using System;
using System.Text;
using PostingServices.Core.Contracts;

namespace PostingServices.Core.Models.PostOffices
{
    public class PostOffice : IPostOffice
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
            private set { this.name = value;  }
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
