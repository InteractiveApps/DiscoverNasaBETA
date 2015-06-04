using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverNasaBETA.Core.Interfaces
{
    interface IDifferenceList<T>
    {
        List<T> minuend { get; set; }
        List<T> subtrahend { get; set; }

        List<T> GetDifference();
    }
}
