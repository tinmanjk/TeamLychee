using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core
{
    interface IAddress
    {

        string City { get; }
        string StreetName { get; }
        int StreetNumber { get; }

        string ToString();
    }
}
