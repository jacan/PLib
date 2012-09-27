using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackWeb.PLib.PartitionPlans
{
    public interface IDataPartition<T>
    {
        ICollection<T> DataCollection { get; set; }

        long Seed { get; set; }
    }
}
