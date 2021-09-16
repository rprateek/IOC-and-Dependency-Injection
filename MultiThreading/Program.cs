using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;

namespace MultiThreading
{
    class Program
    {             
        static void Main(string[] args) // Thread 1 - This is the application thrad
        {

            
            for (int i = 0; i < 1000; i++)
            {
                Task t = new Task(Function1);
                //Thread t = new Thread(Function1);
                t.Start();
                
            }

            Console.ReadLine();          

        }      

        private static void Function1()
        {
            string a = "";
            a = "asdf";
        }
       
        static void RunMillionRecords()
        {
            string a = "";
            for (int i = 0; i < 1000000; i++)
            {
                a = a + "a";
                
            }
            Console.WriteLine(a);
        }
       
    }


    
}
