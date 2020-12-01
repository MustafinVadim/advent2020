using System.Collections.Generic;
using System.Linq;

namespace Tools
{
	public static class PairsFinder
	{
		public static (int, int)? FindPair(int sum, HashSet<int> input)
		{
			return input.Where(s => input.Contains(sum - s))
				.Select(t => ((int, int)?)(t, sum - t))
				.FirstOrDefault();
		}
		
		public static (int, int, int)? FindTriple(int sum, HashSet<int> input)
		{
			return input.Select(i => (i, FindPair(sum - i, input)))
				.Where(i => i.Item2 != null)
				.Select(i => (i.i, i.Item2.Value.Item1, i.Item2.Value.Item2))
				.FirstOrDefault();
		}
	}
}