using System;
using System.Diagnostics;

public class Euler6
{
	public static void Main()
	{
        // Start timer
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        int sum = 0;
        int square = 0;
        int i = 0;
        for (i = 1; i <= 100; i++)
        {
            sum = sum + (i * i);
            square = square + i;
        }
        square = square * square;
        int diff = square - sum;
        stopWatch.Stop();
        Console.WriteLine("The square is " + square);
        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("The difference between the square and sum is " + diff);
        Console.WriteLine("Time spent calculating: {0}", stopWatch.Elapsed);
	}
}
