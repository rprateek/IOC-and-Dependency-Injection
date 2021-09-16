using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace MultiThreading
{
    class ThreadPoolDemo
    {


        //static void Main(string[] args) // Thread 1 - This is the application thrad
        //{
        //    Console.WriteLine("starting warmup to converte in IL code");
        //    for (int i = 0; i < 10; i++)
        //    {
        //        WithThreadPool();
        //        WithoutThreadPool();

        //    }
        //    Console.WriteLine("end warmup ");

        //    Stopwatch oWatch = new Stopwatch();

        //    Console.WriteLine("Recording With thread Pool");
        //    oWatch.Start();
        //    WithThreadPool();
        //    oWatch.Stop();
        //    Console.WriteLine(oWatch.ElapsedTicks);
        //    oWatch.Reset();

        //    Console.WriteLine("Recording With thread only");
        //    oWatch.Start();
        //    WithoutThreadPool();
        //    oWatch.Stop();
        //    Console.WriteLine(oWatch.ElapsedTicks);
        //    oWatch.Reset();

        //    Console.ReadLine();

        //}

        static void WithoutThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                //creates 10 threads 
                Thread thread = new Thread(Function1);
                thread.Start();
            }
        }
        static void WithThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                //using thread pool
                ThreadPool.QueueUserWorkItem(new WaitCallback(Function1));
            }

        }
        static void Function1(object o)
        {

        }

    }
}
