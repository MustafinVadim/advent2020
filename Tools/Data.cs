using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Tools
{
	public static class Data
	{
		public static IEnumerable<string> GetInput(int day)
		{
			using var client = new HttpClient();
			client.DefaultRequestHeaders.Add("cookie", "session=");
			var stream = client.GetStreamAsync($"https://adventofcode.com/2020/day/{day}/input").Result;
			var reader = new StreamReader(stream);
			string line;
			while ((line = reader.ReadLine()) != null)
				yield return line;
		}
	}
}