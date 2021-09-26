using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class MinMaxSum
    {
        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        //MinMaxSum(arr);
        //Console.ReadLine();

        public void GetEven()
        {
            List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            //var even = from x in myNumbers
            //           where x % 2 == 0
            //           select x; // LINQ to get even numbers

            //Same LINQ query above using API Syntax
            var even = myNumbers.Where(x => x % 2 == 0);


            foreach (var item in even)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void ReverseString(string s)
        {
            //string sCombine="";

            //IEnumerable<char> retChar = s.ToCharArray().Reverse();


            //foreach (char c in retChar)
            //{
            //    sCombine = sCombine + c;                
            //}
            //Console.WriteLine(sCombine);

            // Other method

            char[] arrChar = s.ToCharArray();
            Array.Reverse(arrChar);
            Console.WriteLine(new string(arrChar));
        }
        public void GetMinMaxSum(List<int> arr)
        {
            arr.Sort();
            long min = 0;
            long max = 0;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                min += arr[i];
            }
            for (int j = 1; j < arr.Count; j++)
            {
                max += arr[j];

            }
            Console.WriteLine(min + " " + max);
        }

    }

   

}
