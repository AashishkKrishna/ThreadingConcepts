using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingPractice
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            CancellationToken token = cancellationToken.Token;
            Task task = new Task(() => { Console.WriteLine("Hello"); },token);
            task.Start();
        }

        static void Printmessage(object message)
        {
            Console.WriteLine(message);
        }


        
    }
}
