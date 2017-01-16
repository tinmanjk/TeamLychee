using Infrastructure.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core
{
    interface ILetter
    {

        PaperSize PaperSize { get; }
        string Text { get; }

        string ToString();
    }
}
