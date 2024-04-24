using System;
using System.Diagnostics;
using System.Collections.Generic;

public class Euler38
{
    public static void Main()
    {
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
	int i;
	int j;
	int product;
	long concat;
	string str = "";
	int x;
	long max = 0;
	for (i=20000;i>0;i--)
	{
		concat = 0;
		str = "";
		for (j=1;j<=4;j++)
		{
			product = i*j;
			str += product.ToString();
			concat = long.Parse(str);
			if (concat > 987654321)
			{
				break;
			}
			if (IsPandigital(concat) && concat > max)
			{
				max = concat;
				for (x = 1;x<=j;x++)
				{
				Console.Write(i*x);
				}
				Console.WriteLine();
				break;
			}
		}
	}
    stopwatch.Stop();
    Console.WriteLine("Time: " + stopwatch.Elapsed);
    Console.Read();
	}
	
	public static bool IsPandigital(long x)
	{
	string str = x.ToString();
	const string pandigital = "123456789";
	string sorted = SortString(str);
	if (sorted == pandigital)
	{
	return true;
	}
	else
	{
	return false;
	}
	}
	public static string SortString(string str)
	{
	char[] chars = new char[str.Length-1];
	// Console.WriteLine("input string = " + str);
	chars = str.ToCharArray();
	// Console.WriteLine("char array = " + chars);
	Array.Sort<char>(chars);
	// Console.WriteLine("sorted chars = " + chars);
	string result = new string(chars);
	// Console.WriteLine("result = " + result);
	return result;
	}
}