using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Euler79
{
    class Program
    {
        static void Main(string[] args)
        {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
			string input = "";
			// - READ TEXT FILE TO LIST<STRING>
			using (StreamReader sr = new StreamReader("keylog.txt"))
            {
                String line = sr.ReadToEnd();
                input = line;
            }
			List<string> words = new List<string>(input.Split('\n'));
			
			// - INITIALIZE
			// List<int> a = new List<int>();
			// List<int> b = new List<int>();
			// List<int> c = new List<int>();
			List<int> combos = new List<int>();
			int i = 0;
			
			// - PARSE OUT EACH LINE INTO ARRAYS OF CHAR 1, 2, 3
			
			for (i=0;i<words.Count-1;i++)
			{
				if (!combos.Contains(int.Parse(words[i])))
				{
					combos.Add(int.Parse(words[i]));
					// a.Add(int.Parse(words[i][0].ToString()));
					// b.Add(int.Parse(words[i][1].ToString()));
					// c.Add(int.Parse(words[i][2].ToString()));
				}
			}
						
			// - LIST ALL SETS AS ONE STRING
			/* string str = "";
			for (i=0;i<a.Count;i++)
			{
				str += a[i];
				str += b[i];
				str += c[i];
			} */
				
			// - LIST ALL COMBINATIONS IN paths
			/* combos.Sort();
			for (int s=0;s<combos.Count;s++)
			{
			Console.WriteLine(combos[s]);
			} */
			
			// - GENERATE NESTED LIST TO HOLD "PATHS" FOR EACH DIGIT
			List<List<int>> paths = new List<List<int>>();
			for (i=0;i<10;i++)
			{
				List<int> sublist = new List<int>();
				sublist.Add(i);
				paths.Add(sublist);
			}
			
			// - GO THROUGH COMBOS, PULLING EACH DIGIT FOR PATHS
			for (i=0;i<combos.Count;i++)
			{
				int digit = combos[i]/100;
				int digit3 = combos[i]%10;
				int digit2 = combos[i]%((digit*100)+digit3)/10;
				if (!paths[digit].Contains(digit2))
				{
				paths[digit].Add(digit2);
				}
				if (!paths[digit].Contains(digit3))
				{
				paths[digit].Add(digit3);
				}
			}
			
			// - SPECIAL RULE FOR 0 (COMES AFTER 9)
			paths[9].Add(0);
			
			// - START ARRAY TO REPRESENT FINAL NUMBER, STARTING WITH INITIAL COMBO
			List<int> number = new List<int>(new int[]{3,1,9});
			
			// - FOR EACH DIGIT 1-9, BUILD NUMBER BASED ON "PATHS"
			for (i=0;i<10;i++)
			{	
			// - SPECIAL RULE, NO 4 OR 5 FOUND IN COMBOS
			if (i == 4 || i == 5)
			{
				continue;
			}
			number = Check(number,i,paths[i]);
			}
			
			// - WRITE FINAL NUMBER TO CONSOLE
			for (i=0;i<number.Count;i++)
			{
				Console.Write(number[i]);
			}
			
        stopwatch.Stop();
        Console.WriteLine();
        Console.WriteLine(stopwatch.Elapsed);
		}
		static List<int> Check(List<int> num, int digit, List<int> paths)
		{
			int i=0;
			// - FOR EACH PATH OF DIGIT, CHECK LOCATION IN FINAL NUMBER
			for (i=0;i<paths.Count;i++)
			{
			int path = paths[i];
			// - IF PATH DIGIT IS NOT IN FINAL, ADD AT POS 0
			if (num.IndexOf(path) == -1)
			{
				num.Insert(0,path);
			}
			// - IF DIGIT IS NOT IN FINAL, ADD BEFORE PATH DIGIT
			if (num.IndexOf(digit) == -1)
			{
				num.Insert(num.IndexOf(path),digit);
			}
			// - IF DIGIT COMES AFTER PATH DIGIT, REMOVE DIGIT AND PUT IT BEFORE PATH
			else if (num.IndexOf(digit) > num.IndexOf(path))
			{
				num.RemoveAt(num.IndexOf(digit));
				num.Insert(num.IndexOf(path),digit);
			}
			// - OTHERWISE NUMBER CHECKS OUT
			else if (num.IndexOf(digit) < num.IndexOf(path))
			{
				continue;
			}
			}
			return num;
		}
	}
}
