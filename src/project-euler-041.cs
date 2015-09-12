using System;
using System.Diagnostics;

public class Euler41
{
    static void Main()
    {
	// No pandigitals over 9 digits because 1-9 only usable once
	// All 9-digit pandigitals combine to 45, not prime because divisible by 9
	// All 8-digit pandigitals combine to 36, also divisible by 9
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
	int i;
	string str = "";
	int max = 7654321;
	int min = 1234567;
	for (i=max;i>=min;i-=2)
	{
		str = i.ToString();
		if (IsPandigital(str) && PrimeTest(i))
		{
			break;
		}
	}
    stopwatch.Stop();
    Console.WriteLine("Largest pandigital prime: " + str);
    Console.WriteLine("Time: " + stopwatch.Elapsed);
    Console.Read();
	}
	
	static bool IsPandigital(string x)
	{
	string str = x;
	const string pandigital = "1234567";
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
	
	static string SortString(string str)
	{
	char[] chars = new char[str.Length-1];
	chars = str.ToCharArray();
	Array.Sort<char>(chars);
	string result = new string(chars);
	return result;
	}
	
	static bool PrimeTest(long x){
		long i;
		if (x%2 != 0 || x == 2 || x != 1) {
			for (i=3;i*i<=x;i++)	{
				if (x%i==0)	{
					return false;
				}
			}
				return true;
		}
		else {
		return false;
		}
	}
		}