using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class asTest
	{
		
		public async Task izvrsi()
		{
			await Task.WhenAll(hullo(), ello());
		}
		public async Task hullo()
		{
			int i = 0;
			while (i < 100)
			{
				await Task.Delay(1000);
				Console.WriteLine($"hullo {i}");
				i++;
			}
			return;
		}
		public async static Task ello()
		{
			int i = 0;
			while (i < 100)
			{
				await Task.Delay(1000);
				Console.WriteLine($"ello {i}");
				i++;
			}
			return;
		}
	}
}