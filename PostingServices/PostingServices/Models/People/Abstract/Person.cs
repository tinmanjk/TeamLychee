namespace PostingServices.People
{

    using System;
    using System.Text;
    using Infrastructure;
    using Infrastructure.Constants;
    using Core;
    public abstract class Person: IPerson
    {
        //fields
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private const string PhoneNumberProperty = "PhoneNumber";
        private const string FirstNameProperty = "Firstname";
        private const string LastNameProperty = "Lastname";
        //properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value; 
            }
        }
        public string Lastname
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            private set
            {
                this.phoneNumber = value;
            }
        }

        //constructors
        public Person(string firstname, string lastname, string phoneNumber)
        {
            
            this.firstName = firstname;
            this.lastName = lastname;
            this.phoneNumber = phoneNumber;
            ValidateFields();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name: {0} {1}\n", this.firstName, this.lastName);
            result.AppendFormat("{0}: {1}\n", PhoneNumberProperty, this.phoneNumber);

            return result.ToString();
        }
        private void ValidateFields()
        {
            
            Validator.ValidateNull(this.firstName, string.Format(ErrorMsgs.PropertyCannotBeNull, FirstNameProperty));
            Validator.ValidateIntRange(this.firstName.Length, ErrorMsgs.MinNameLength, ErrorMsgs.MaxNameLength, string.Format(ErrorMsgs.StringMustBeBetweenMinAndMax, FirstNameProperty, ErrorMsgs.MinNameLength, ErrorMsgs.MaxNameLength));

            Validator.ValidateNull(this.lastName, string.Format(ErrorMsgs.PropertyCannotBeNull, LastNameProperty));
            Validator.ValidateIntRange(this.lastName.Length, ErrorMsgs.MinNameLength, ErrorMsgs.MaxNameLength, string.Format(ErrorMsgs.StringMustBeBetweenMinAndMax, LastNameProperty, ErrorMsgs.MinNameLength, ErrorMsgs.MaxNameLength));

            Validator.ValidateNull(this.phoneNumber, string.Format(ErrorMsgs.PropertyCannotBeNull, PhoneNumberProperty));
            Validator.ValidateNumber(this.phoneNumber.Length, ErrorMsgs.PhoneNumberLength,string.Format(ErrorMsgs.NumberMustBeEqual, PhoneNumberProperty,ErrorMsgs.PhoneNumberLength));
            

        }
    }
}
