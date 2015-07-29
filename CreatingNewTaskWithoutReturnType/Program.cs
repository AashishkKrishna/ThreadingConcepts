using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingNewTaskWithoutReturnType
{
    class Program
    {
        /// <summary>
        /// Runs separately on different thread
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Task t = Task.Run(
                () =>
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("{0}", i);
                    }
                });
            
            t.Wait(); // Use to finish the tast, if not specified task wont run as no separate thread allocated.
            Console.WriteLine("Running in Main thread");
        }
    }
}
