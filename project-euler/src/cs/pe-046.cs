using System;
using System.Diagnostics;
using System.Collections.Generic;
public class Euler46 {
	static void Main() {
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		int max = 10000;
		List<int> primes = Primes(max);
		List<int> doubles = DoubleSquares(max);
		List<int> composites = Composites(max);
		List<int> sums = Sums(primes,doubles);
		for (int c=0;c<composites.Count;c++) {
		if (composites[c] % 2 != 0 && !sums.Contains(composites[c])) {
			stopwatch.Stop();
			Console.WriteLine("Answer: " + composites[c]);
			Console.WriteLine("Timer: " + stopwatch.Elapsed);
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
	static List<int> DoubleSquares(int input) {
		List<int> doubles = new List<int>();
		int n = 1;
		for (n=1;(n*n)*2<=input;n++) {
			doubles.Add(2*(n*n));
		}
		return doubles;
	}
	static List<int> Composites(int input) {
		List<int> composites = new List<int>();
		int n = 4;
		int i = 2;
		for (n=4;n<=input;n++) {
			for (i=2;i<n;i++) {
			if (n % i == 0) {
					composites.Add(n);
			}
			else continue;
			}
		}
		return composites;
	}
	static List<int> Sums(List<int> primes, List<int> doubles) {
		List<int> sums = new List<int>();
		for (int p=0;p<primes.Count;p++) {
		for (int d=0;d<doubles.Count;d++) {
			sums.Add(primes[p]+doubles[d]);
		}
		}
		return sums;
	}
}