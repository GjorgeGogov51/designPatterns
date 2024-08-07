using System;
using System.Collections.Generic;
using System.Threading;

namespace _2_FluentBuilderInheritanceWithRecursiveGenerics
{
	public class Person
	{
		public string Name;
		public string Position;

		public override string? ToString()
		{
			return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
		}
	}

	public class PersonInfoBuilder
	{
		protected Person person = new Person();

		public PersonInfoBuilder Called(string name)
		{
			person.Name = name;
			return this;
		}
	}
	public class PersonJobBuilder : PersonInfoBuilder
	{
		public PersonJobBuilder WorksAsA(string position)
		{
			person.Position = position;
			return this;
		}
	}
	internal class Program
	{
		public static void Main(string[] args)
		{
			var builder = new PersonJobBuilder();
			builder.Called("dmitri");
			//can't call WorksAsA
		}
	}
}
