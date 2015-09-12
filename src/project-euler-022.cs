using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class Euler22
{
    public static void Main()
    {
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
	List<string> names = new List<string>();
	List<string> characters = new List<string>();
	string[] ls = new string[6000];
	int i = 0;
	int sum = 0;
	int total = 0;
	// Read file into string array ls
    foreach (string line in File.ReadAllLines("names.txt"))
	{
	ls = Regex.Split(line, ",");
	}
	// Add names to List names
	foreach (string s in ls)
	{
	names.Add(s);
	}
	// Sort names alphabetically
	names.Sort();
	// For each name, add value * position to total
	for (i=0;i<names.Count;i++)
	{
	sum = NameValue(names[i]);
	total += sum * (i+1);
	}
	// Results
    stopwatch.Stop();
    Console.WriteLine("Total: " + total);
    Console.WriteLine("Time: " + stopwatch.Elapsed);
    Console.Read();
	}
	
	// Find value of name per letter value, ignoring non-alpha chars
	public static int NameValue(string name)
	{
	int sum = 0;
	int i;
	for (i=0;i<name.Length;i++)
	{
	switch (name[i].ToString())
	{
	case "A": sum += 1; break; 
	case "B": sum += 2; break;
	case "C": sum += 3; break;
	case "D": sum += 4; break;
	case "E": sum += 5; break;
	case "F": sum += 6; break;
	case "G": sum += 7; break;
	case "H": sum += 8; break;
	case "I": sum += 9; break;
	case "J": sum += 10; break;
	case "K": sum += 11; break;
	case "L": sum += 12; break;
	case "M": sum += 13; break;
	case "N": sum += 14; break;
	case "O": sum += 15; break;
	case "P": sum += 16; break;
	case "Q": sum += 17; break;
	case "R": sum += 18; break;
	case "S": sum += 19; break;
	case "T": sum += 20; break;
	case "U": sum += 21; break;
	case "V": sum += 22; break;
	case "W": sum += 23; break;
	case "X": sum += 24; break;
	case "Y": sum += 25; break;
	case "Z": sum += 26; break;
	default: break;
	}
	}
	return sum;
	}
}
