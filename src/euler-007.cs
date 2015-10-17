using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Euler7 {
	static bool Prime(int num)
	{
		int high = (int) Math.Truncate(Math.Sqrt(num));
		IEnumerable range = Enumerable.Range(2, high);
		if (high >= 2) {
			foreach (int i in range) {
				if (num % i == 0) {
					return false;
				}
			}
		}
		return true;
	}

	static void Main()
	{
		int[] init = new int[] {2};
		List<int> primes = new List<int>(init);
		for (int i = 3; primes.Count < 10001; i+=2) {
			if (Prime(i)) {
				primes.Add(i);
			}
		}
		Console.WriteLine(primes.Last());
	}
}