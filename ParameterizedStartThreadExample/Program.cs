using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParameterizedStartThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(
                //using Lambda Expression
                (object obj) =>
                {
                    for (int i = 0; i < (int)obj; i++)
                    {
                        Console.WriteLine("ThreadMethod:- {0}", i);
                        Thread.Sleep(0);
                    }
                }));

            //using delegate
            Thread thread1 = new Thread(new ParameterizedThreadStart(ThreadMethod));
            
            
            thread.Start(5); //input passed at start overload method
            thread.Join();
        }


        public static void ThreadMethod(object obj)
        {
            for (int i = 0; i < (int)obj; i++)
            {
                Console.WriteLine("ThreadMethod:- {0}",i);
                Thread.Sleep(0);
            }
        }
    }
}
