using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Addresses
{
    public class Address
    {
        private string city;
        private string streetName;
        private uint streetNumber;

        // add properties

        public Address(string city, string streetName, uint streetNumber)
        {
            this.city = city;
            this.streetName = streetName;
            this.streetNumber = streetNumber;
        }
    }
}
