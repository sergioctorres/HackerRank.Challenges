using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    /* Challenge URL: https://www.hackerrank.com/challenges/time-conversion/problem */

    static string timeConversion(string s)
    {
        try
        {
            DateTime hour = DateTime.Parse(s);

            return hour.ToString("HH:mm:ss");
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
