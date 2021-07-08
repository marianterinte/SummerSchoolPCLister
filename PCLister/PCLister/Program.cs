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

				default:
					{
						pcBuilder = new BudgetPCBuilder();
						break;

					}
			}

			pcBuilder.Build();
			PC pc = pcBuilder.GetPC();

			BuilderMin displayMin = new BuilderMin();
			BuilderFull displayFull = new BuilderFull();
			BuilderId displayId = new BuilderId();


			switch (format)
			{
				case "min":
					displayMin.Display(format);
					break;

				case "full":
					displayFull.Display(format);
					break;

				case "id":
					displayId.Display(format);
					break;

				default:
					Console.WriteLine("You did not choose a correct Display");
					break;
			}

		}
	}
}
