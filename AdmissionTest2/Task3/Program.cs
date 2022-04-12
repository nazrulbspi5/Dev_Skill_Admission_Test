using Task3;
using System;

class Program
{

	// Main Method
	static public void Main(String[] args)
	{
		FractionPrinter printer = new FractionPrinter();
		Console.WriteLine(printer.Print(22, 7, 50));
	}
}