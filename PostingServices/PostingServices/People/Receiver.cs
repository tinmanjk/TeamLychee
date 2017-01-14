using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.Addresses;

namespace PostingServices.People
{
    public class Receiver : Person
    {
        private Address address;

        //add address property

        public Receiver(string name, string phoneNumber, Address address) : base(name, phoneNumber)
        {
            this.address = address;
        }
    }
}
