using PostingServices.Core;
using PostingServices.Primitives.Address;

namespace PostingServices.People
{

    public class Receiver : Person, IReceiver
    {
        private Address address;

        //add address property

        public Address Address
        {
            get { return this.address; }
            private set { }
        }

        public Receiver(string firstname,string lastname, string phoneNumber, Address address) 
            :base(firstname,lastname, phoneNumber)
        {
            this.Address = address;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Address: {0}\n");
        }
    }
}
