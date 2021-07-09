using System;

namespace PCLister
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("PC Type(budget/basic/performant/high-end): ");
			var pcType = Console.ReadLine();

			Console.WriteLine("Display (min/full/id): ");
			var format = Console.ReadLine();

			var pcBuilderFactory = new PCBuilderFactory();
			PCBuilder pcBuilder = pcBuilderFactory.Get(pcType);

			pcBuilder.Build();
			PC pc = pcBuilder.GetPC();

			PCFormatter pcFormatter = new PCFormatter();
			pcFormatter.Display(pc, format);
		}
	}
}
