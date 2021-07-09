using System;

namespace PCLister.Formatters
{
	public class IdPCFormatter : IPCFormatter
	{
		public void Display(PC pc)
		{
			Console.WriteLine("ID_" + pc.MotherboardMake + "_" + pc.ProcessorMake + "_" + pc.ProcessorFrequency);
		}
	}
}
