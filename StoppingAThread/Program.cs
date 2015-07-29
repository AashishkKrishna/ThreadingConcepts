using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoppingAThread
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isStopped = false; // using a bool data type to maintain the state of the thread
            Thread thread = new Thread(new ThreadStart(
                () =>
                {
                    while (!isStopped)
                    {
                        Console.WriteLine("Thread is running - {0}",Thread.CurrentThread.Priority);
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine("Thread stopped running");
                }));
            thread.Start();
            Console.WriteLine("Press key to stop the running thread");
            Console.ReadKey();
            isStopped = true;
            thread.Join();
        }
    }
}
