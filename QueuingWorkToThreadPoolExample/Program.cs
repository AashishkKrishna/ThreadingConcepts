using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QueuingWorkToThreadPoolExample
{

    //Still doubtful about this concept
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(
                (s) => Console.WriteLine("Working on Thread from Threadpool"));
            Console.ReadLine();
        }
    }
}
