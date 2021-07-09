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
			PCBuilder pcBuilder;

			switch (pcType)
			{
				case "basic":
					{
						pcBuilder = new BasicPCBuilder();
						break;
					}

				case "performant":
					{
						pcBuilder = new PerformantPCBuilder();
						break;
					}

				case "high-end":
					{
						pcBuilder = new HighEndPCBuilder();
						break;
					}

				case "budget"
					{
						pcBuilder = new BudgetPCBuilder();
						break;
					}
			}

			pcBuilder.Build();
			PC pc = pcBuilder.GetPC();
			pc.PrintSpecs(format);
		}
	}
}