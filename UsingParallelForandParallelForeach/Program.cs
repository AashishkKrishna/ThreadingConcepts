using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingParallelForandParallelForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For and Parallel.For
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Parallel For starts:-");
            Thread.Sleep(2000);

            Parallel.For(0, 10, (i) =>
            {
                Console.WriteLine(i);
            });
            #endregion

            #region Foreach and Parallel.Foreach

            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int item in a)
            {
                Console.WriteLine(item);
                Thread.Sleep(1000);
            }

            Parallel.ForEach(a,(i) =>
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                });
            #endregion

        }
    }
}
