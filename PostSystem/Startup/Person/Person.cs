using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public abstract class Person : IPerson
    {

        private string name;

        private int phoneNumber;

        public string Name
        {
            get { return this.name; }       
            set { this.name = value; }            //validation
        }
        public int PhoneNumber
        {
            get { return this.phoneNumber; }            
            set { this.phoneNumber = value; }       //validation
        }

    }
}
