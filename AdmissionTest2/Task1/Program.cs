using System;
using Task1;
class Program
{

	// Main Method
	static public void Main(String[] args)
	{

		

		var text = Console.ReadLine();

		var frequencyCounter = new FrequencyCounter();
		var result = frequencyCounter.Count(text);

		Console.WriteLine(result);
	}
}


