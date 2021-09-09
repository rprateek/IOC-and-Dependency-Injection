using System;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    /// <summary>
    /// What are Delegates? 
    /// The whole point of delegates is to listen to Async Tasks.  
    /// Also look into Multicast delegates, Action, Predicate and Func
    /// Say when is task is being executed in multi threaded environment, when we want to stream that data then we use delegates.
    /// Event is Encapsulation over delgates
    /// Now try go complete Events how it works find out
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            NewClass x = new NewClass();

            x.streamObj = IamADelegateListner; // let the Delegate know that there is someone listening to you 

            Task t = new Task(x.Work);
            t.Start();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        static void IamADelegateListner(int i)
        {
            Console.WriteLine("work: " + i); // now move the writeline here it will stream here. 
        }

    }

    class NewClass
    {
        public delegate void StreamOfWork(int i); //declaration of delegate
        public StreamOfWork streamObj; //create a instance
        public void Work()
        {
            for (int i = 0; i < 100000; i++)
            {
                Thread.Sleep(1000);
                streamObj(i);
                //Console.WriteLine("work: " + i);

            }
        }
        
    }
}
