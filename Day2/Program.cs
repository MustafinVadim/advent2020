using System;
using System.Collections.Generic;
using System.Linq;
using Tools;

namespace Day2
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Data.GetInput(2).ToList();
			
			Console.WriteLine(Part1(input));
			Console.WriteLine(Part2(input));
		}

		private static int Part1(List<string> input)
		{
			var result = 0;
			foreach (var item in input)
			{
				var parts = item.Split(' ');
				var counts = parts[0].Split('-');
				var minCount = int.Parse(counts[0]);
				var maxCount = int.Parse(counts[1]);
				var letter = parts[1][0];
				var password = parts[2];

				var currentCount = 0;

				foreach (var l in password)
				{
					if (l == letter)
						currentCount++;
				}

				if (currentCount >= minCount && currentCount <= maxCount)
					result++;
			}

			return result;
		}

		private static int Part2(List<string> input)
		{
			return (from item in input 
				select item.Split(' ') into parts 
				let counts = parts[0].Split('-') 
				let firstIndex = int.Parse(counts[0]) - 1 
				let secondIndex = int.Parse(counts[1]) - 1 
				let letter = parts[1][0]
				let password = parts[2] 
				where password[firstIndex] == letter != (password[secondIndex] == letter) 
				select firstIndex).Count();
		}
	}
}