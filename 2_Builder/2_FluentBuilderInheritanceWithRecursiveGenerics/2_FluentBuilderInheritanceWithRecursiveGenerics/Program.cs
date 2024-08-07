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
	public abstract class PersonBuilder
	{
		protected Person person = new Person();
		public Person Build()
		{
			return person;
		}
	}
	//Casting to SELF in order to have the correct data type, instead of for ex. int
	public class PersonInfoBuilder<SELF> : PersonBuilder
		where SELF : PersonInfoBuilder<SELF>
	{
		public SELF Called(string name)
		{
			person.Name = name;
			return (SELF) this;
		}
	}
	// PersonJobBuilder : PersonInfoBuilder<PersonJobBuilder> is a bad idea for further classes that inherit
	public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>>
		where SELF : PersonJobBuilder<SELF>
	{
		public SELF WorksAsA(string position)
		{
			person.Position = position;
			return (SELF) this;
		}
	}
	internal class Program
	{
		public static void Main(string[] args)
		{
			
		}
	}
}
