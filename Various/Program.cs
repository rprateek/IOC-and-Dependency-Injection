using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        // Homework
        // How to implement thread safety and thread pooling?
        // Show how TPL tasks run on multiple cores. You can use processor performance counters. 
        // stackoverflow.com/questions/52914450/performance-comparison-between-thread-and-task-using-c-sharp
        //Provide Async/Await does not create threads? - Use thread debugging to check if new threads are created
        //stackoverflow.com/questions/1050222/what-is-the-difference-between-concurrency-and-parallelism 

        // What is stack trace and how to create custom exceptions?

        struct coordintes
        {
            public int x;
            public int y;
            public int z;
        }
        static void Main(string[] args)
        {


            //Thread t1 = new Thread(ThreadFun1);
            // t1.Name = "First Thread";


            // Thread t2 = new Thread(ThreadFun1);
            // t2.Name = "Second Thread";
            //t1.Start();
            //t2.Start();
            // test cache          

            
                TextInput input = new NumericInput();
                input.Add('1');
                input.Add('a');
                input.Add('0');
                Console.WriteLine(input.GetValue());



            ////To run multiple functions parallelly 
            Thread t1 = new Thread(new ThreadStart(ThreadFun1));
            Thread t2 = new Thread(new ThreadStart(ThreadFun2));

            t1.Start(); // strts executing function1 parallely
            t2.Start(); // starts executing function2 parallely

            // TPL uses multi core and doesn't have thread affinity. and task is better to use than thread.
            //Task tsk1 = new Task(ThreadFun1);
            //Task tsk2 = new Task(ThreadFun2);

            //tsk1.Start();
            //tsk2.Start();


            // ThreadFun1();
            //ThreadFun2();

            //Console.WriteLine("Hello World!"); // This will run parallelly which means output will be 
            //Output: Hello World
            // This is Function 1 & counter value is: 1
            //This is Function 2 & counter value is: 1 
            //....

        }

        /// <summary>
        ///  Threading will run in singele processor 
        ///  Whereas TPL (Task parallel Library) uses separate processors and actually run parallel executions and is better than Threads.
        /// </summary>
        /// 


        static async void ThreadFun1()
        {
            for (int i = 0; i < 100000; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("This is function 1 & counter value is:" + i);
            }
        }
        static async void ThreadFun2()
        {
            for (int i = 0; i < 1000; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("This is function 2 & counter value is:" + i);
            }

        }


        static void Function1()
        {
            Console.WriteLine("function1 is Started");
            Console.ReadLine();
            Console.WriteLine("function1 is Ended");
        }


        //static void ThreadFun1()
        //{
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        i++;
        //        Thread.Sleep(1000);
        //        Console.WriteLine("This is function 1 & counter value is:" + i );
        //    }
        //}
        //static void ThreadFun2()
        //{
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine("This is function 2 & counter value is:" + i);
        //    }

        //}


    }
    
}
