namespace PostingServices.People
{
    using System;
    using System.Text;
    public abstract class Person
    {
        //fields
        private string name;
        private string phoneNumber;

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value; 
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
        public Person(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Name: {0}\n", this.name);
            result.AppendFormat("Phone Number: {0}\n", this.phoneNumber);

            return result.ToString();
        }
    }
}
