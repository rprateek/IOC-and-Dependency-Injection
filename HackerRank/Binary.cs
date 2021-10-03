using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Binary
    {
        //List<List<int>> arr = new List<List<int>>();
        //int[][] arr = new int[6][];

        //    for (int i = 0; i< 6; i++)
        //    {
        //        arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        //      //  arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        //    }

    // Console.WriteLine(Binary.hourglassSum(arr));

        public static int hourglassSum(int[][] arr)
        {
            int maxSum = int.MinValue;
            int rows = arr.Length - 2;
            for (int j = 0; j < rows; j++)
            {
                int columns = arr[j].Length - 2;

                for (int k = 0; k < columns; k++)
                {
                    int sum = arr[j][k] + arr[j][k + 1] + arr[j][k + 2]
                                        + arr[j + 1][k + 1]
                        + arr[j + 2][k] + arr[j + 2][k + 1] + arr[j + 2][k + 2];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }



        static int R = 5;
        static int C = 5;

        // Returns maximum sum of
        // hour glass in ar[][]




        public static int findMaxSum(int[,] mat)
        {
            if (R < 3 || C < 3)
                return -1;

            // Here loop runs (R-2)*(C-2)
            // times considering different
            // top left cells of hour glasses.
            int max_sum = int.MinValue;
            for (int i = 0; i < R - 2; i++)
            {
                for (int j = 0; j < C - 2; j++)
                {
                    // Considering mat[i][j] as top
                    // left cell of hour glass.
                    int sum = (mat[i, j] + mat[i, j + 1] +
                               mat[i, j + 2]) + (mat[i + 1, j + 1]) +
                              (mat[i + 2, j] + mat[i + 2, j + 1] +
                               mat[i + 2, j + 2]);

                    // If previous sum is less then
                    // current sum then update
                    // new sum in max_sum
                    max_sum = Math.Max(max_sum, sum);
                }
            }
            return max_sum;
        }


        public static int maxConsecutiveOnes(int x)
        {

            // Initialize result
            int count = 0;

            // Count the number of iterations
            // to reach x = 0.
            while (x != 0)
            {

                // This operation reduces length
                // of every sequence of 1s by one.
                x = (x & (x << 1));

                count++;
            }

            return count;
        }
    }
}
