using System;
using System.Collections.Generic;

namespace PCLister
{
	//V2.
	class Program
	{
		static List<PC> initStock()
        {
			List<PC> pcStock = new List<PC>();
			string line;
			string[] component;
			System.IO.StreamReader file = new System.IO.StreamReader(@"../../../stock.txt");
			while((line = file.ReadLine()) != null)
            {
				component = line.Split(' ');
				pcStock.Add(new PC(component[0], component[1], component[2], component[3], component[4], component[5]));
            }
			return pcStock;
		}
		static void Main(string[] args)
		{
			List<PC> pcStock = new List<PC>();
			pcStock = initStock();

			Console.WriteLine("PC Type: ");
			var pcType = Console.ReadLine();

			Console.WriteLine("Processor: ");
			var processorMake = Console.ReadLine();

			Console.WriteLine("Display: ");
			var format = Console.ReadLine();

			foreach(PC pc in pcStock)
            {
				if(pc.getProcessorMake() == processorMake && pc.getPcType() == pcType)
                {
					pc.printSpecs(PC.convertInput(format));
                }
            }

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
