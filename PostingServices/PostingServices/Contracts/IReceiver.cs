using PostingServices.Primitives.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core
{
    interface IReceiver
    {

        Address Address { get; }

        string ToString();
    }
}
