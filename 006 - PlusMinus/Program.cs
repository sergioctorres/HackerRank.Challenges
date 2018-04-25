using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    /*
     * Complete the plusMinus function below.
     */
    static void plusMinus(int[] arr)
    {
        int positives = 0;
        int negatives = 0;
        int zeros = 0;

        foreach (var item in arr)
        {
            if (item > 0)
                positives++;
            else if (item < 0)
                negatives++;
            else
                zeros++;
        }

        Console.WriteLine("{0:N6}", (float)positives / arr.Length);
        Console.WriteLine("{0:N6}", (float)negatives / arr.Length);
        Console.WriteLine("{0:N6}", (float)zeros / arr.Length);
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}
