using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BuilderPattern
{
	public class Demo
	{
		static void Main(string[] args)
		{
			var hello = "hello";
			var sb = new StringBuilder();
			sb.Append("<p>");
			sb.Append(hello);
			sb.Append("</p>");
			WriteLine(sb);

			var words = new[] { "hello", "world" };
			sb.Clear();
			sb.Append("<ul>");
			foreach(var word in words) 
			{
				sb.AppendFormat($"<li>{word}</li>");
			}
			sb.Append("</ul>");
			WriteLine(sb);

		}
	}
}
