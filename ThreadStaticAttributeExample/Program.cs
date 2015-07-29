using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStaticAttributeExample
{
    class Program
    {
        [ThreadStatic] // using this attribute property every thread has its own copy of that variable
        static int _field;
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(
                () =>
                {
                    for (int i = 0; i < 5; i++)
                    {
                        _field++;
                        Console.WriteLine("Thread 1:- {0}", _field);
                    }
                }));
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(
                () =>
                {
                    for (int i = 0; i < 5; i++)
                    {
                        _field++;
                        Console.WriteLine("Thread 2:- {0}", _field);
                    }
                }));
            thread2.Start();
        }
    }
}
