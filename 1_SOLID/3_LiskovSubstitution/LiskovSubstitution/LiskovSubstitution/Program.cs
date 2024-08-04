﻿using System;
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
		public class Square : Rectangle 
		{
			public new int Width 
			{
				set 
				{
					base.Width = base.Height = value;
				} 
			}
			public new int Height
			{
				set 
				{
					base.Width = base.Height = value;
				}
			}
		}

		static public int Area(Rectangle r) => r.Width * r.Height;
		static void Main(string[] args)
		{
			Rectangle rc = new Rectangle(2,3);
			WriteLine($"{rc} has area {Area(rc)}");

			//If square is changed to rectangle, doesn't work as expected
			//Which breaks the Liskov Substitution principle 
			Rectangle sq = new Square();
			sq.Width = 4;
			WriteLine($"{sq} has area {Area(sq)}");
		}
	}
}
