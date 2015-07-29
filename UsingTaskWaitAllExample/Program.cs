using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTaskWaitAllExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(
                () =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Task 1");
                });
            tasks[1] = Task.Run(
                () =>
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Task 2");
                });
            tasks[2] = Task.Run(
                () =>
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("Task 3");
                });
            Task.WaitAll(tasks); //Waits for all the tasks to get over, returns Void
        }
    }
}
