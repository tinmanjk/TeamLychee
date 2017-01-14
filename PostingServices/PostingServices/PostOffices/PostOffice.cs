using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.Structs;

namespace PostingServices.PostOffices
{
    public class PostOffice
    {
        private string name;
        private Location location;

        //properties

        //constructor
        public PostOffice(string name, Location location)
        {
            this.name = name;
            this.location = location;
        }
    }
}
