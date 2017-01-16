using PostingServices.Primitives.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core
{
    interface IParcel
    {
        Dimensions Dimensions { get; }
        string Content { get; }

        string ToString();
    }
}
