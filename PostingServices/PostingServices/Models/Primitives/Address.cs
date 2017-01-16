namespace PostingServices.Primitives.Address
{
    using Core;
    using Infrastructure;
    using Infrastructure.Constants;
    using System;
    using System.Text;
    public struct Address:IAddress    //make me struct
    {
        private string city;
        private string streetName;
        private int streetNumber;

        // add properties
        public string City
        {
            get { return this.city; }
        }
        public string StreetName
        {
            get { return this.streetName; }
            private set { }
        }
        public int StreetNumber
        {
            get { return this.streetNumber; }

        }



        public Address(string city, string streetName, int streetNumber)
        {
            this.city = city;
            this.streetName = streetName;
            this.streetNumber = streetNumber;
            ValidateFields();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("City: {0}\n", this.city);
            result.AppendFormat("Street: {0}\n", this.streetName);
            result.AppendFormat("Street number: {0}\n", this.streetNumber);

            return result.ToString();
        }
        private void ValidateFields()
        {

            Validator.ValidateNull(this.city, string.Format(ErrorMsgs.PropertyCannotBeNull, "City"));
            Validator.ValidateIntRange(this.city.Length, ErrorMsgs.MinCityNameLength, ErrorMsgs.MaxCityNameLength, 
                string.Format(ErrorMsgs.StringMustBeBetweenMinAndMax, "City", ErrorMsgs.MinCityNameLength, ErrorMsgs.MaxCityNameLength));

            Validator.ValidateNull(this.streetName, string.Format(ErrorMsgs.PropertyCannotBeNull, "Streetname"));
            Validator.ValidateIntRange(this.streetName.Length, ErrorMsgs.MinStreetNameLength, ErrorMsgs.MaxStreetNameLength, 
                string.Format(ErrorMsgs.StringMustBeBetweenMinAndMax, "Streetname", ErrorMsgs.MinStreetNameLength, ErrorMsgs.MaxStreetNameLength));

            Validator.ValidateNull(this.streetNumber, string.Format(ErrorMsgs.PropertyCannotBeNull, "Streetnumber"));
            Validator.ValidateIntRange(this.streetNumber, ErrorMsgs.MinStreetNameLength, ErrorMsgs.MaxStreetNameLength, 
                string.Format(ErrorMsgs.StringMustBeBetweenMinAndMax, "Streetnumber", ErrorMsgs.MinStreetNameLength, ErrorMsgs.MaxStreetNameLength));


        }
    }
}
