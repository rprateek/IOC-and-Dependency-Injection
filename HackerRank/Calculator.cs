using System;

namespace HackerRank
{
    internal class Calculator1
    {


        //Calculator myCalculator = new Calculator();
        //int T = Int32.Parse(Console.ReadLine());
        //    while (T-- > 0)
        //    {
        //        string[] num = Console.ReadLine().Split();
        //int n = int.Parse(num[0]);
        //int p = int.Parse(num[1]);
        //        try
        //        {
        //            int ans = myCalculator.power(n, p);
        //Console.WriteLine(ans);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);

        //        }
        //    }

        public Calculator1()
        {
        }

        internal int power(int n, int p)
        {
            double retVal=0;
            try
            {
                if (n<0 || p<0)
                {
                    throw new Exception("n and p should be non-negative");
                }

               retVal=  Math.Pow(n, p);

                return Convert.ToInt32(retVal);
            }
            catch (Exception)
            {

                throw new Exception("n and p should be non-negative");
            }
            
        }
    }
}