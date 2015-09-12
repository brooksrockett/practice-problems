using System;
using System.Diagnostics;

public class Class1
{
	public static void Main()
	{
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int y = 38;
        int x = 1;
        while (x <= 20)
            {
                if (y % x == 0)
                {
                    if (x == 20)
                    {
                        stopwatch.Stop();
                        Console.WriteLine("{0}", stopwatch.Elapsed);
                        Console.WriteLine("{0}", y);
                        Console.ReadLine();
                    }
                    x++;
                }
                else
                {
                    x = 1;
                    y = y + 38;
                }
            }
        }   
	}
