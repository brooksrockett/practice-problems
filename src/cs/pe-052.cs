using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Euler52 {
	static void Main() {
		int i = 1;
		bool stop = false;
		while (stop == false) {
			i++;
			// if (i==100000) {Console.WriteLine("pause");Console.Read();}
			if (Check(i,i.ToString()) == true) {
				Console.WriteLine(i);
				stop = true;
			}
		}
	}
	public static bool Check(int x, string original) {
		bool checksout = false;
		int i = 1;
		for (i = 1; i<7; i++) {
			if (SortString((x*i).ToString()) == SortString(original)) {
				checksout = true;
			} else return false;
		}
		if (checksout ==  false) return false; else return true;
	}
	public static string SortString(string str) {
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