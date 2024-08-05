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

	public interface IRelationshipBrowser
	{
		IEnumerable<Person> FindAllChildrenOf(string name);
	}

	//low-level
	public class Relationships : IRelationshipBrowser
	{
		private List<(Person, Relationship, Person)> Relations
			= new List<(Person, Relationship, Person)> ();

		public void AddParentAndChild(Person parent, Person child)
		{
			Relations.Add((parent, Relationship.Parent, child));
			Relations.Add((child, Relationship.Child, parent));
		}

		public IEnumerable<Person> FindAllChildrenOf(string name)
		{
			foreach (var r in Relations.Where(
				x => x.Item1.Name == name &&
				x.Item2 == Relationship.Parent
				))
			{
				yield return r.Item3;
			}
		}
		//Without Dependency Inversion, changing the Relationships class is an issue

		//public List<(Person, Relationship, Person)> relations => Relations;
	}
	//high-level
	public class Research
	{
		/*
		public Research(Relationships relationships)
		{
			var relations = relationships.relations;
			foreach (var r in relations.Where(
				x => x.Item1.Name == "John" &&
				x.Item2 == Relationship.Parent
				))
			{
				WriteLine($"John has a child called {r.Item3.Name}");
			}
		}*/
		public Research (IRelationshipBrowser browser)
		{
			foreach (var p in browser.FindAllChildrenOf("John"))
				WriteLine($"John has a child called {p.Name}");
		}
		static void Main(string[] args)
		{
			
			var parent = new Person() { Name = "John" };
			var child1 = new Person() { Name = "Chris" };
			var child2 = new Person() { Name = "Mary" };

			var relationships = new Relationships();
			relationships.AddParentAndChild(parent, child1);
			relationships.AddParentAndChild (parent, child2);

			new Research(relationships);
		}
	}
}
