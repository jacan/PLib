using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JackWeb.PLib.PartitionPlans
{
    public class ClassicRoundRobinStrategy<T> : ISelectionStrategy<T>
    {
        private long _index;

        public long Index
        {
            get { return _index; }
        }

        public T Next(IDataPartition<T> dataPartition)
        {
            T data = default(T);

            var mod = Index % dataPartition.Seed;

            Interlocked.Decrement(ref _index);

            return data;
        }
    }
}
