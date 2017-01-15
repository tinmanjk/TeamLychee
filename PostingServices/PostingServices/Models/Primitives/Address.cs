namespace PostingServices.Primitives.Address
{

    public class Address    //make me struct
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
