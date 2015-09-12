using System;
using System.Diagnostics;
using System.Collections.Generic;

public class Euler30
{
    public static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
		// Need to count from i ~ 5000 ish (write them to see where the cutoff is)
		// Split digits of i and find Fourth(i[0]) to Fourth(i[-1])
		// Sum them all together
		// Remember not to include 1 in the final sum
		string x;
		int i = 0;
		int j = 0;
		int y = 0;
		int sum = 0;
		int total = 0;
		for (i=2;i<200000;i++)
		{
		x = i.ToString();
		sum = 0;
		for (j=0;j<x.Length;j++)
		{
		y = Convert.ToInt32((x[j]).ToString());
		sum += Fifth(y);
		}
		if (sum == i)
		{
		total += sum;
		}
		}
        stopwatch.Stop();
		Console.WriteLine("Total: " + total);
        Console.WriteLine("Time: " + stopwatch.Elapsed);
        Console.Read();
	}
	public static int Fifth(int input)
	{
	return (int) Math.Pow(input,5);
	}
}
