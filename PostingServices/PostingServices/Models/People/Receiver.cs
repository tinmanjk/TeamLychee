using PostingServices.Primitives.Address;

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
