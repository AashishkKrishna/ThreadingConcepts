using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTypes_Foreground_Background_JoinExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(ThreadMethod));

            thread.IsBackground = true; // Default thread is foreground, setting property to true makes thread to background
            thread.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Method:-{0}",i);
                Thread.Sleep(0);
            }

            thread.Join(); // Waits for all background process to finish then continue
            Console.WriteLine("After Join");
        }

        static void ThreadMethod()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("ThreadMethod:- {0}",i);
                Thread.Sleep(0);
            }
        }
    }
}
