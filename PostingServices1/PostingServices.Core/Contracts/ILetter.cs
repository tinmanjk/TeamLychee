using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostingServices.Core.Infrastructure.Enumerations;

namespace PostingServices.Core.Contracts
{
    interface ILetter
    {

        PaperSize PaperSize { get; }
        string Text { get; }

        string ToString();
    }
}
