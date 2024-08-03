using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OpenClosed
{
	public enum Color
	{
		Red,Green, Blue
	}
	public enum Size
	{
		Small, Medium, Large, Huge
	}
	public class Product
	{
		public string Name;
		public Color Color;
		public Size Size;

        public Product(string name, Color color, Size size)
        {
            if (name == null)
				throw new ArgumentNullException(paramName: nameof(name));

			Name = name;
			Color = color;
			Size = size;
        }
    }

	public class Demo
	{
		static void Main(string[] args)
		{
			
		}
	}
}
