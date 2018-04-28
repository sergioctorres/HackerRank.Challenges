using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    /* Challenge URL: https://www.hackerrank.com/challenges/diagonal-difference/problem */

    static int diagonalDifference(int[][] a)
    {
        int sumX = 0;
        int sumY = 0;

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i; j < a[i].Length; j++)
            {
                sumX += a[i][j];
                break;
            }
        }

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = a[i].Length - (i+1); j >= 0; j--)
            {
                sumY += a[i][j];
                break;
            }
        }

        return Math.Abs(sumX - sumY);
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] a = new int[n][];

        for (int aRowItr = 0; aRowItr < n; aRowItr++)
        {
            a[aRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        }

        int result = diagonalDifference(a);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
