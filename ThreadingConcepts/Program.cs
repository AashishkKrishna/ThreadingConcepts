using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CreatingBAsicThread
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(ThreadMethod); // Delegate created to pass to thread
            thread.Start();
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Main Method:- {0}",i);
                Thread.Sleep(0);
            }
        }

        static void ThreadMethod()
        {
            for (int i = 0; !(i >= 10); i++)
			{
                Console.WriteLine("ThreadMethod:- {0}", i);
		        Thread.Sleep(0);
            }
        }
    }
}
