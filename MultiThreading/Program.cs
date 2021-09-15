using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static Maths obj = new Maths();
        static void Main(string[] args)
        {
            
            Thread t1 = new Thread(obj.Divide);            
            t1.Start(); // Child Thread
            obj.Divide();// Main Thread
            
            // Exits the function
            Console.WriteLine("ApplicationQuits");
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
                lock(this)
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
