using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HackerRank
{
     
    class Result
    {

        /*
         * Complete the 'timeConversion' function below.
         *c
         * The function is expected to return a STRING. - 19:05:45
         * The function accepts STRING s as parameter. -- 07:05:45PMc
         */

        public static string timeConversion(string s)
        {
            DateTime dt = Convert.ToDateTime(s);
            return dt.ToString("HH:mm:ss");
        }


        public static void fizzBuzz(int n)
        {

            //bool bRunning = true;
            //while (bRunning)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine().Trim());
            //    Result.fizzBuzz(n);

            //}


            for (int i = 0; i < n; i++)
            {
                if ((i+1) % 3 == 0 && (i + 1) % 5 == 0)
                {

                    Console.WriteLine("FizzBuzz");
                }
                else if ((i+1) % 3 == 0)
                {

                    Console.WriteLine("Fizz");
                }
                else if ((i+1) % 5 == 0)
                {

                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine((i+1).ToString());
                }
            }
            
        }

    }





    class Solution
    {
        //public static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string s = Console.ReadLine();

        //    string result = Result.timeConversion(s);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }

}
