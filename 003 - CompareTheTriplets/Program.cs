using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    /* Challenge URL: https://www.hackerrank.com/challenges/compare-the-triplets */

    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
    {
        int[] points = new int[2];

        int alice = (a0 > b0 ? 1 : 0) + (a1 > b1 ? 1 : 0) + (a2 > b2 ? 1 : 0);
        int bob =  (b0 > a0 ? 1 : 0) + (b1 > a1 ? 1 : 0) + (b2 > a2 ? 1 : 0);

        points[0] = alice;
        points[1] = bob;

        return points;

    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] a0A1A2 = Console.ReadLine().Split(' ');

        int a0 = Convert.ToInt32(a0A1A2[0]);

        int a1 = Convert.ToInt32(a0A1A2[1]);

        int a2 = Convert.ToInt32(a0A1A2[2]);

        string[] b0B1B2 = Console.ReadLine().Split(' ');

        int b0 = Convert.ToInt32(b0B1B2[0]);

        int b1 = Convert.ToInt32(b0B1B2[1]);

        int b2 = Convert.ToInt32(b0B1B2[2]);

        int[] result = solve(a0, a1, a2, b0, b1, b2);

        tw.WriteLine(string.Join(" ", result));

        tw.Flush();
        tw.Close();
    }
}
