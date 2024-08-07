using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _3_StepwiseBuilder
{
	public enum CarType
	{
		Sedan, Crossover
	}
	public class Car
	{
		//Car type determines Wheel Size, so we need a separate interface for each
		public CarType type;
		public int WheelSize;
	}
	public class Demo
	{
		static void Main(string[] args)
		{

		}
	}
}
