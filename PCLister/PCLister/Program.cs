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
			BasePCBuilder pcBuilder = pcBuilderFactory.Get(pcType);

			pcBuilder.Build();
			PC pc = pcBuilder.GetPC();

			var pcFormatterFactory = new PCFormatterFactory();
			IPCFormatter pcFormatter = pcFormatterFactory.Get(format);

			pcFormatter.Display(pc);
		}
	}
}
