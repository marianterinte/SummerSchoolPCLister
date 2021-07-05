using System;

namespace PCLister
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("PC Type: ");
			var pcType = Console.ReadLine();

			Console.WriteLine("Display: ");
			var display = Console.ReadLine();

			var pc = new PC("Asus", "AMD", "4Ghz", "16GB", "3600Mhz");

			Console.WriteLine("Motherboard: " + pc.motherboardMake);
			Console.WriteLine("Processor: " + pc.processorMake);
			Console.WriteLine("Processor Freq: " + pc.processorFrequency);
			Console.WriteLine("Ram Size: " + pc.ramSize);
			Console.WriteLine("Ram Frequency: " + pc.ramFrequency);

			//basic
			//AMD
			//min

			// Motherboard: Asus
			// Processor: AMD
			// Processor Freq: 4Ghz
			// Ram Size: 16GB
			// Ram Freq: 3600 Mhz

		}
	}
}
