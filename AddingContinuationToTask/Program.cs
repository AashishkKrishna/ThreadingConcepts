using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingContinuationToTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> t = Task.Run(
                () =>
                {
            //        throw new Exception();
                    return "ABC";
                });

            t.ContinueWith((i) =>
                {
                    Console.WriteLine("Faulted");
                },TaskContinuationOptions.OnlyOnFaulted);


            t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            //Console.WriteLine("Result = {0}",t.Result);
        }
    }
}
