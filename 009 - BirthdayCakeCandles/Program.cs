using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    /* Challenge URL: https://www.hackerrank.com/challenges/birthday-cake-candles/problem */

    static int birthdayCakeCandles(int n, int[] ar)
    {
        int? bigCandle = null;

        foreach (var heightCandle in ar)
        {
            if (heightCandle > bigCandle || bigCandle == null)
                bigCandle = heightCandle;
        }

        return ar.Where(x => x == bigCandle).Count();
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(n, ar);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
