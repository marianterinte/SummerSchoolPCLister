using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
    class BuilderId
    {
		PC pc;

		public void Display(string format)
		{
			switch (format)
			{
				case "budget":
					Console.WriteLine("ID_" + pc.MotherboardMake + "_" + pc.ProcessorMake + "_" + pc.ProcessorFrequency);
					break;

				case "basic":
					Console.WriteLine("ID_" + pc.MotherboardMake + "_" + pc.ProcessorMake + "_" + pc.ProcessorFrequency);
					break;

				case "performant":
					Console.WriteLine("ID_" + pc.MotherboardMake + "_" + pc.ProcessorMake + "_" + pc.ProcessorFrequency);
					break;

				case "high-end":
					Console.WriteLine("ID_" + pc.MotherboardMake + "_" + pc.ProcessorMake + "_" + pc.ProcessorFrequency);
					break;

				default:
					Console.WriteLine("You did not choose a correct PC type");
					break;

			}
		}
	}
}
