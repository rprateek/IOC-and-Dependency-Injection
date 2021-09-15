
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ReadWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);

        }       
    }


    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            int pos = 0;
            int neg = 0;
            int zero = 0;
            foreach (int i in arr)
            {
                if (i > 0)
                {
                    pos++;
                }
                else if (i < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }
            }
            int count = arr.Count;
            decimal posRatio =(decimal)pos / (decimal)count;
           
            decimal negRatio = (decimal)neg / (decimal)count;
            decimal zeroRatio = (decimal)zero / (decimal)count;
            Console.WriteLine(Math.Round(posRatio,6));
            Console.WriteLine(Math.Round(negRatio, 6));
            Console.WriteLine(Math.Round(zeroRatio, 6));


        }

    }

    public class Tree<T>
    {
        private Node<T> root;

        public Tree(T rootData)
        {
            root = new Node<T>();
            root.data = rootData;
            root.children = new List<Node<T>>();
        }
    }
    public class Node<T>
    {
        public T data;
        public Node<T> parent;
        public List<Node<T>> children;
    }




}
