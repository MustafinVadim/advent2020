using System;
using System.Collections.Generic;
using System.Linq;
using Tools;

namespace Day1
{
	class Program
	{
		static void Main()
		{
			var input = Data.GetInput(1)
				.Select(int.Parse)
				.ToHashSet();
			
			Console.WriteLine(Part1(input));
			Console.WriteLine(Part2(input));
		}

		static int? Part1(HashSet<int> input)
		{
			var pair = PairsFinder.FindPair(2020, input);
			return pair == null
				? (int?)null
				: pair.Value.Item1 * pair.Value.Item2;
		}

		static int? Part2(HashSet<int> input)
		{
			var triple = PairsFinder.FindTriple(2020, input);
			return triple == null
				? (int?) null
				: triple.Value.Item1 * triple.Value.Item2 * triple.Value.Item3;
		}
	}
}