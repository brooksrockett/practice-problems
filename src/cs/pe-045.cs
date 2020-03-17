using System;
using System.Diagnostics;
using System.Collections.Generic;

public class Euler24
{
    static void Main()
    {
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		long n;
		long curtri;
		long curpent;
		long curhex;
		List<long> tri = new List<long>();
		List<long> pent = new List<long>();
		List<long> hex = new List<long>();
		for (n=1;n<999999999;n++)
		{
			curtri = (n*(n+1))/2;
			curpent = (n*((3*n)-1))/2;
			curhex = n*(2*n-1);
			tri.Add(curtri);
			pent.Add(curpent);
			hex.Add(curhex);
			Console.WriteLine(curpent);
			if (tri.Contains(curtri) && pent.Contains(curtri) && hex.Contains(curtri) && tri.Count>285)
			{
				stopwatch.Stop();
				Console.WriteLine("Final number: " + curtri);
				Console.WriteLine("Triangle term: " + n);
				Console.WriteLine("Time: " + stopwatch.Elapsed);
				Console.Read();
				break;
			}
		}		
	}
}