using System;

namespace PCLister.Formatters
{
	public class MinPCFormatter : IPCFormatter
	{
		public void Display(PC pc)
		{
			Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
		}
	}
}
