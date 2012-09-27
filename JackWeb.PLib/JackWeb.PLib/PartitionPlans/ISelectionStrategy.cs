using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackWeb.PLib.PartitionPlans
{
    public interface ISelectionStrategy<T>
    {
        long Index { get; }
        T Next(IDataPartition<T> dataPartion);
    }
}
