using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MultiThreading
{
    class Synchronisations
    {


        public void Lock ()
        {
            Maths obj = new Maths();
            Thread t1 = new Thread(obj.Divide);
            t1.Start();

            obj.Divide(); // this will have to wait until the lock is released. 
        }


        Mutex m1 = null;
        public void MutexRun()
        {

            using (Mutex m1 = new Mutex(false, "MultiThreadingMutex")) // make initially owned and give the name of the mutex
            {
                if (!m1.WaitOne(5000, false))// Wait for 5 secs, don't exit context but show message. 
                {

                    Console.WriteLine("Another instance is running");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Application does something");
                Console.WriteLine("Application quits");
                Console.ReadLine();

            }
        }


        Semaphore sem = null;
        public void Semaphore()
        {
            try
            {
                sem = new Semaphore(3, 3, "SemaphoreName"); // three threads can pass at one time
            }
            catch (Exception ex)
            {
                sem = new Semaphore(3, 3, "SemaphoreName"); // if fails to instantitate then create a new one. here.
            }

            Console.WriteLine("Waiting at the gate - Ready to Own");

            sem.WaitOne(); // From here till the release only 3 threads can access this area. 
            Console.WriteLine("Thread Owned -- I am inside");
            Console.ReadLine();

            sem.Release();
            Console.ReadLine();

        }

        //static ManualResetEvent oAuto = new ManualResetEvent(false);
        //static void Main(string[] args) // Thread 1 - This is the application thrad
        //{

        //    new Thread(TaskToDo).Start(); // This is 2nd thread -- it will execute taskToDo in a thread
        //    Console.ReadLine();
        //    oAuto.Set(); // release waitOne at 1

        //}

        static void TaskToDo()
        {
            //Console.WriteLine("Starting 1 ...");
            //oAuto.WaitOne();

            //Console.WriteLine("Finishing 1...");

            //Console.WriteLine("Starting 2 ...");
            //oAuto.WaitOne();

            //Console.WriteLine("Finishing 2...");
        }
    }

    class Maths
    {
        public int num1;
        public int num2;

        Random o = new Random();
        public void Divide()
        {
            for (long i = 0; i < 1000; i++)
            {
                lock (this)
                {
                    num1 = o.Next(1, 2);
                    num2 = o.Next(1, 2);
                    int result = num1 / num2;
                    num1 = 0;
                    num2 = 0;
                    Console.WriteLine(result.ToString());
                }

            }
        }
    }
}
