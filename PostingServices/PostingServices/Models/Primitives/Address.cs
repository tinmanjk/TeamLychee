namespace PostingServices.Primitives.Address
{
    using System;
    using System.Text;
    public struct Address    //make me struct
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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("City: {0}\n", this.city);
            result.AppendFormat("Street: {0}\n", this.streetName);
            result.AppendFormat("Street number: {0}\n", this.streetNumber);

            return result.ToString();
        }
    }
}
