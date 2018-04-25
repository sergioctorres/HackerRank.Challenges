using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the staircase function below.
     */
    static void staircase(int n)
    {
        string spaces = string.Empty;
        string hashtag = string.Empty;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                spaces += " ";
            }

            for (int k = 1; k <= i; k++)
            {
                hashtag += "#";
            }

            Console.WriteLine(spaces + hashtag);

            spaces = string.Empty;
            hashtag = string.Empty;
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
