using System;
using System.Diagnostics;
using System.Collections.Generic;

public class Euler24
{
    public static void Main()
    {
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
	long i;
	string str = "";
	int count = 0;
	for (i=0123456789;i<9876543210;i+=9)
	{
		if (i < 1000000000) {
			str = "0" + i.ToString();
		}
		else if (i >= 1000000000)
		{
			str = i.ToString();
		}
		if (IsPandigital(str))
		{
			count++;
		}
		if (count == 1000000)
		{
			break;
		}
	}
    stopwatch.Stop();
    Console.WriteLine("Final permutation: " + str);
    Console.WriteLine("Time: " + stopwatch.Elapsed);
    Console.Read();
	}
	
	public static bool IsPandigital(string x)
	{
	string str = x;
	const string pandigital = "0123456789";
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