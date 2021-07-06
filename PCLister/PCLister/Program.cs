using System;

namespace PCLister
{
	//V2.
	class Program
	{
		static void initStock()
        {

        }
		static void Main(string[] args)
		{
			initStock();

			Console.WriteLine("PC Type: ");
			var pcType = Console.ReadLine();

			Console.WriteLine("Processor: ");
			var processorMake = Console.ReadLine();

			Console.WriteLine("Display: ");
			var format = Console.ReadLine();

			var pc = new PC("Asus", "AMD", "4Ghz", "16GB", "3600Mhz");

			pc.printSpecs(PC.convertInput(format));

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
