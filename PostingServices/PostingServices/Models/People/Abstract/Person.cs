using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.People
{
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
            //
        }
    }
}
