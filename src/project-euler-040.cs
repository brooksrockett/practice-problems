using System;
using System.Diagnostics;

public class Euler40
{
    static void Main()
    {
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
	long i;
	string str = "";
	long total = 1;
	int start = 1;
	int gen = DigitGenerator(start-1)+1;
	int stop = start*10;
	// Console.WriteLine(Generator(9)+1);
	/* Using DigitGenerator() I find that the 10s start at digit 10
	* 100s start at digit 190
	* 1000s at 2890
	* 10000s at 38890
	* 100000s at 488890 and
	* 1000000s at 5888890 */
	while (start < 1000000)
	{
	gen = DigitGenerator(start-1)+1;
	stop = start*10;
	str = "";
	for (i=start;i<=stop;i++)
	{
		str+=i.ToString();
		if (str.Length>(stop-gen))
		{
		total *= Int32.Parse(str[stop-gen].ToString());
		// Console.WriteLine("End of round: " + stop + " Found digit " + str[stop-gen] + " Current Total: " + total);
		start *= 10;
		break;
		}
	}
	}
    stopwatch.Stop();
    Console.WriteLine("Total: " + total);
    Console.WriteLine("Time: " + stopwatch.Elapsed);
    Console.Read();
	}
	static int DigitGenerator(int max)
	{
		int i;
		int count = 0;
		for (i=1;i<10 && i<=max;i++)
		{
			count++;
		}
		
		for (i=10;i<100 && i<=max;i++)
		{
			count+=2;
		}
		
		for (i=100;i<1000 && i<=max;i++)
		{
			count+=3;
		}
		
		for (i=1000;i<10000 && i<=max;i++)
		{
			count+=4;
		}
		
		for (i=10000;i<100000 && i<=max;i++)
		{
			count+=5;
		}
		
		for (i=100000;i<1000000 && i<=max;i++)
		{
			count+=6;
		}
		
		return count;
	}
		}