using PostingServices.Core.Models.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core.Contracts
{
    interface IReceiver
    {

        Address Address { get; }

        string ToString();
    }
}
