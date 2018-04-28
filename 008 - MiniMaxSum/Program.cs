using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    /* Challenge URL: https://www.hackerrank.com/challenges/mini-max-sum/problem */

    static void miniMaxSum(int[] arr)
    {
        long sum = 0;
        long minSum = 0;
        long maxSum = 0;
        bool firstSum = true;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (j != i)
                    sum += arr[j];
            }

            if (sum < minSum || firstSum)
                minSum = sum;

            if (sum > maxSum || firstSum)
                maxSum = sum;

            if (i == 0)
                firstSum = false;

            sum = 0;
        }

        Console.WriteLine(minSum + " " + maxSum);
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        miniMaxSum(arr);
    }
}
