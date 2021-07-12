using System;

namespace PCLister
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("PC Type(budget/basic/performant/high-end): ");
			var pcType = Console.ReadLine();

			Console.WriteLine("Display (min/full/id): ");
			var format = Console.ReadLine();

			var pcFormatterFactory = new PCFormatterFactory();
			IPCFormatter pcFormatter = pcFormatterFactory.Get(format);

			// Strategy pattern
			var pcConfigurationService = new PCConfigurationService(pcType);
			pcConfigurationService.SetFormatter(pcFormatter);
			pcConfigurationService.Display();
		}
	}
}
