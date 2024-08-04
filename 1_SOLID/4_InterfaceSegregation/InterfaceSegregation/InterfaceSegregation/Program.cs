using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InterfaceSegregation
{
	public class Document
	{

	}
	public interface IMachine
	{
		void Print(Document d);
		void Scan(Document d);
		void Fax(Document d);

	}
	public class MultiFunctionPrinter : IMachine
	{
		public void Fax(Document d)
		{
			//
		}

		public void Print(Document d)
		{
			//
		}

		public void Scan(Document d)
		{
			//
		}
	}
	public class OldFashionedPrinter : IMachine
	{
		public void Print(Document d)
		{
			//
		}

		// Don't need these
		public void Fax(Document d)
		{
			throw new NotImplementedException();
		}
		public void Scan(Document d)
		{
			throw new NotImplementedException();
		}
	}
	public class Demo
	{
		static void Main(string[] args)
		{
			
		}
	}
}
