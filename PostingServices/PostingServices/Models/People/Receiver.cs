using PostingServices.Primitives.Address;

namespace PostingServices.People
{

    public class Receiver : Person
    {
        private Address address;

        //add address property

        public Receiver(string firstname,string lastname, string phoneNumber, Address address) 
            :base(firstname,lastname, phoneNumber)
        {
            this.address = address;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Address: {0}\n");
        }
    }
}
