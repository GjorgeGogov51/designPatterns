using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LiskovSubstitution
{
	public class Demo
	{
		public class Rectangle
		{
			public int Width { get; set; }
			public int Height { get; set; }
            public Rectangle()
            {
                
            }
			public Rectangle(int width, int height)
			{
				Width = width;
				Height = height;
			}
			//Formatting member
			public override string ToString()
			{
				return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
			}

		}
		static void Main(string[] args)
		{
			Rectangle rc = new Rectangle();
		}
	}
}
