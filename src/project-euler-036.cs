using System;
using System.Diagnostics;

public class Euler97
{
    public static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int i;
        int total = 0;
        for (i = 0; i < 1000000; i++)
        {
            string num = Convert.ToString(i);
            if (IsPalindrome(num) && IsPalindrome(ToBinary(i)))
            {
                total += i;
            }
        }
        stopwatch.Stop();
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Time: " + stopwatch.Elapsed);
        Console.Read();
    }
    static string ToBinary(int x)
    {
        return Convert.ToString(x, 2);
    }
    static bool IsPalindrome(string x)
    {
        int i;
        string str = x;
        string reverse = "";
        for (i = str.Length - 1; i >= 0; i--)
        {
            reverse += str[i];
        }
        if (str == reverse)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
