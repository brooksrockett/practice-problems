using System;
using System.Diagnostics;
using System.Collections.Generic;

public class Euler32
{
    public static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
	const int max = 987654321;
	const int min = 123456789;
	long i;
	long j;
	long product = 0;
	long concat = 0;
	long total = 0;
	List<long> products = new List<long>();
        for (i=2000;i>=1;i--)
		{
		for (j=1;j<=1000;j++)
		{
		product = i*j;
		concat = long.Parse(i.ToString() + j.ToString() + product.ToString());
		if (concat >= min && concat <= max)
		{
		if (IsPandigital(concat) && products.Contains(product) == false)
		{
		products.Add(product);
		total += product;
		// Console.WriteLine("{0} * {1} = {2}", i, j, product);
		}
		}
		else continue;
		}
		}
        stopwatch.Stop();
		Console.WriteLine("Total: " + total);
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
