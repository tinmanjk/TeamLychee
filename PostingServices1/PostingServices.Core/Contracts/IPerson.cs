using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core.Contracts
{
    interface IPerson
    {
        string FirstName { get; }
        string Lastname { get; }
        string PhoneNumber { get; }

        string ToString();

    }
}
