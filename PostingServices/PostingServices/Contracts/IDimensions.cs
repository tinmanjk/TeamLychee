using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostingServices.Core
{
    interface IDimensions
    {
        double Width { get; }
        double Height { get; }
        double Length { get; }
        double Weight { get; }

        string ToString();
    }
}
