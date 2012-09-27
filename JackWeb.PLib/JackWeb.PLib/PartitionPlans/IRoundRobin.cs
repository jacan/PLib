using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackWeb.PLib.PartitionPlans
{
    public interface IRoundRobin<T> : IDataPartition<T>
    {
        ISelectionStrategy<T> Strategy { get; set; }
        T Get();
    }
}
