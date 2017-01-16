using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.Core.Models.Primitives;

namespace PostingServices.Core.Contracts
{
    interface IParcel
    {
        Dimensions Dimensions { get; }
        string Content { get; }

        string ToString();
    }
}
