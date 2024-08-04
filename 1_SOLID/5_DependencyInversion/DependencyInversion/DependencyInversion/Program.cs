using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DependencyInversion
{
	public enum Relationship
	{
		Parent, Child, Sibling
	}
	public class Person
	{
		public string Name;
	}

	//low-level
	public class Relationships
	{
		private List<(Person, Relationship, Person)> Relations
			= new List<(Person, Relationship, Person)> ();

		public void AddParentAndChild(Person parent, Person child)
		{
			Relations.Add((parent, Relationship.Parent, child));
			Relations.Add((child, Relationship.Child, parent));
		}
	}
	//high-level
	public class Research
	{
		static void Main(string[] args)
		{
			var parent = new Person() { Name = "John" };
			var child1 = new Person() { Name = "Chris" };
			var child2 = new Person() { Name = "Mary" };

			var relationships = new Relationships();
			relationships.AddParentAndChild(parent, child1);
			relationships.AddParentAndChild (parent, child2);
		}
	}
}
