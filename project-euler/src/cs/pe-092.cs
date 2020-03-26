using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Collections.Generic;
class Euler92 {
	static void Main() {
		/*
  		*	I could probably speed this
		*	up by adding an extra list
		*	that stores the steps
		*	of each loop with the
		*	end result and check it
		*	each time SquareDigits() is called
		*/
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		int i = 0;
		int result = 0;
		int count = 0;
		for (i=1;i<10000000;i++) {
			result = SquareDigits(i);
			if (result == 1) {
				continue;
			} else if (result == 89) {
				count++;
				continue;
			}
		}
		stopwatch.Stop();
		Console.WriteLine(count);
		Console.WriteLine(stopwatch.Elapsed);
	}
	static int SquareDigits(int i) {
		int j = 0;
		int sum = 0;
		string str = i.ToString();
		checked {
			for (j=0;j<str.Length;j++) {
				int digit = int.Parse(str[j].ToString());
				sum += digit*digit;
			}
			if (sum == 1 || sum == 89) {
				return sum;
			} else {
				return SquareDigits(sum);
			}
		}
	}
}