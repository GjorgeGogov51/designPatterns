using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
	public static class WorldsDumbestFunctionTests
	{
		//Naming Convention - ClassName_MethodName_ExpectedResults
		public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString()
		{
			try
			{
				//Arrange - Go get your variables, classes, functions
				int num = 0;
				WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

				//Act - Execute this function
				string result = worldsDumbest.ReturnsPikachuIfZero(num);

				//Assert - Whatever is returned, is what you want
				if (result.Equals("PIKACHU!"))
				{
					Console.WriteLine("PASSED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString");
				}
				else
				{
					Console.WriteLine("FAILED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnsString");
				}

			}
			catch (Exception ex) 
			{
				Console.WriteLine(ex);
			}
		}

	}
}
