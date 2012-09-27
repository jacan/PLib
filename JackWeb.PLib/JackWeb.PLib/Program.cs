using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JackWeb.PLib.PartitionPlans;

namespace JackWeb.PLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var threadId = 1;
            var someNumbers = new int?[] { 1,2,3,4,5,6,7,8,9,10 };
            var roundRobin = new RoundRobin<int?>(someNumbers);

            var numThreads = Environment.ProcessorCount - 1;

            // Mangler en <.ToNullable>!!!
            //
            ThreadPool.QueueUserWorkItem(
                (x) => {
                    var currentThread = threadId;
                    Interlocked.Increment(ref threadId);

                    var data = x as RoundRobin<int>;
                    var currentData = new Nullable<int>();

                    while((currentData = data.Get()) != null)
                    {
                        Console.WriteLine("Thread {0} got data {1}'", currentThread, currentData);
                    }
                    
                   
                }, roundRobin);

            Console.ReadKey();
        }
    }
}
