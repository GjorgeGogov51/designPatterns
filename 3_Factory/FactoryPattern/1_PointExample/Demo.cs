using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1_PointExample
{
	public enum CoordinateSystem
	{
		Cartesian,
		Polar
	}
	public class Point
	{
		private double x, y;
		//Can't rename constructor

		/// <summary>
		/// Initializes a point from either Cartesian or Polar
		/// </summary>
		/// <param name="a"> if cartesian, rho if polar</param> 
		/// <param name="b"></param>
		/// <param name="system"></param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public Point(double a, double b, 
			CoordinateSystem system = CoordinateSystem.Cartesian)
		{
			switch(system)
			{
				case CoordinateSystem.Cartesian:
					x = a;
					y = b;
					break;
				case CoordinateSystem.Polar:
					x = a * Math.Cos(b);
					y = a * Math.Sin(b);
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(system), system, null);
			}
		}

	}
	public class Demo
	{
		public static void Main(string[] args)
		{
			WriteLine("hemlo");
		}
	}
}
