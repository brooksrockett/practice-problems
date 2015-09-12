using System;
using System.Diagnostics;
using System.Collections.Generic;
public class Euler47 {
	static void Main() {
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		int max = 500000;
		int min = 1000;
		int divisors = 0;
		int count = 0;
		List<int> primes = Primes(min);
		for (int n=min;n<max;n++) {
			divisors = 0;
		for (int i=0;i<primes.Count;i++) {
			if (n % primes[i] == 0)
			{
				divisors++;
			}
		}
		if (divisors >= 4) {
			count++;
		}
		else
		{
			count=0;
		}
		if (count >= 4) {
			stopwatch.Stop();
			Console.WriteLine(n-3);
			Console.WriteLine(stopwatch.Elapsed);
			break;
		}
		}
	}
	static List<int> Primes(int input) {
		List<int> notprimes = new List<int>();
		List<int> primes = new List<int>();
		int n = 2;
		int i = 2;
		for (n=2;n<=input;n++) {
			if (notprimes.Contains(n)) {
				continue;
			} else {
				primes.Add(n);
				for (i=2;i*n<=input;i++) {
					notprimes.Add(i*n);
				}
			}
		}
		return primes;
	}
}