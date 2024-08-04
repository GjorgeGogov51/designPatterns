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

		// Don't need these here
		public void Fax(Document d)
		{
			throw new NotImplementedException();
		}
		public void Scan(Document d)
		{
			throw new NotImplementedException();
		}
	}

	public interface IPrinter
	{
		void Print(Document d);
	}
	public interface IScanner
	{
		void Scan(Document d);
	}

	public class Photocopier : IPrinter, IScanner
	{
		public void Print(Document d)
		{
			throw new NotImplementedException();
		}

		public void Scan(Document d)
		{
			throw new NotImplementedException();
		}
	}

	//You can also have
	public interface IMultiFunctionDevice : IScanner, IPrinter //....
	{

	}

	public class MultiFunctionDevice : IMultiFunctionDevice
	{
		private IPrinter printer;
		private IScanner scanner;

		public MultiFunctionDevice(IPrinter printer, IScanner scanner)
		{
			this.printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer));
			this.scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));
		}

		//Decorator pattern
		public void Print(Document d)
		{
			printer.Print(d);
		}
		public void Scan(Document d)
		{
			scanner.Scan(d);
		}
	}

	public class Demo
	{
		static void Main(string[] args)
		{
			
		}
	}
}
