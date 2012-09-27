using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackWeb.PLib.PartitionPlans
{
    public class RoundRobin<T> : IRoundRobin<T>
    {
        private long _roundtrip;

        public RoundRobin(ICollection<T> dataCollection)
        {
            _roundtrip = dataCollection.Count;
            DataCollection = dataCollection;
        }

        public long Seed 
        { 
            get; 
            set; 
        }

        public ISelectionStrategy<T> Strategy
        {
            get;
            set;
        }

        public ICollection<T> DataCollection
        {
            get;
            set;
        }

        public T Get()
        {
            T data = default(T);

            if (DataCollection.Count > 0)
            {
                data = Strategy.Next(this);
                DataCollection.Remove(data);
            }

            return data;
        }
    }
}
