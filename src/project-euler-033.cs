using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
class Euler33 {
	static void Main() {
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		int n = 10;
		int d = 10;
		double productn = 1;
		double productd = 1;
		for (n = 10; n<100; n++) {
			for (d = 10; d<100; d++) {
				if (d%10 != 0 && n%10 == d/10) {
					double a = Convert.ToDouble(n)/Convert.ToDouble(d);
					double b = Convert.ToDouble(n/10)/Convert.ToDouble(d%10);
					if (a == b && a != 1) {
						Console.WriteLine("{0}/{1}",n,d);
						productn *= n;
						productd *= d;
					}
				}
			}
		}
		Console.WriteLine("Time: " + stopwatch.Elapsed);
		Console.WriteLine("Product numerator: " + productn);
		Console.WriteLine("Product denominator: " + productd);
		Console.WriteLine("Reduced product: 1/" + 1/(productn/productd));
		Console.Read();
	}
}