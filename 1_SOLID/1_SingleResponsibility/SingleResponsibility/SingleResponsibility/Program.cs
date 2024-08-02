using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SingleResponsibility
{
	public class Journal
	{
		private readonly List<string> entries = new List<string>();
		private static int count = 0;
		public int AddEntry(string text)
		{
			entries.Add($"{++count}: {text}");
			return count; // memento pattern
		}
		public void RemoveEntry(int index)
		{
			entries.RemoveAt(index); //unstable
		}
		public override string ToString()
		{
			return string.Join(Environment.NewLine, entries);
		}

		//Too much

		public void Save(string filename)
		{
			File.WriteAllText(filename,ToString());
		}
		public static Journal Load(string filename)
		{

		}
		public void Load(Uri uri)
		{

		}
	}

	public class Demo
	{
		static void Main(string[] args)
		{
			var j = new Journal();
			j.AddEntry("I cried today");
			j.AddEntry("I solved a bug");
			WriteLine(j); //calls ToString
		}
	}
}
