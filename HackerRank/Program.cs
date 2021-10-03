using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HackerRank
{
    class Solution
    {
        //while ((sinput = Console.ReadLine()) != null)
        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Stack<char> stack = new Stack<char>();
        private object dequeueCharacter()
        {
            throw new NotImplementedException();
        }

        private object popCharacter()
        {
            throw new NotImplementedException();
        }

        private void enqueueCharacter(char c)
        {
           
        }

        private void pushCharacter(char c)
        {
            stack.Push(c);
           
        }
        public static int simpleArraySum(List<int> ar)
        {
            int sum = Convert.ToInt32(ar.Sum());
            return sum;
        }
        static void Main(string[] args)
        {

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = simpleArraySum(ar);

            Console.WriteLine(result);
            


            //// read the string s.
            //string s = Console.ReadLine();

            //// create the Solution class object p.
            //Solution obj = new Solution();

            //// push/enqueue all the characters of string s to stack.
            //foreach (char c in s)
            //{
            //    obj.pushCharacter(c);
            //    obj.enqueueCharacter(c);
            //}

            //bool isPalindrome = true;

            //// pop the top character from stack.
            //// dequeue the first character from queue.
            //// compare both the characters.
            //for (int i = 0; i < s.Length / 2; i++)
            //{
            //    if (obj.popCharacter() != obj.dequeueCharacter())
            //    {
            //        isPalindrome = false;

            //        break;
            //    }
            //}

            //// finally print whether string s is palindrome or not.
            //if (isPalindrome)
            //{
            //    Console.Write("The word, {0}, is a palindrome.", s);
            //}
            //else
            //{
            //    Console.Write("The word, {0}, is not a palindrome.", s);
            //}
        }

       
    }  
}
