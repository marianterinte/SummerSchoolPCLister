using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
    class BuilderMin
    {
        PC pc;
        
      public void Display(string format)
        {
			switch (format)
			{
				case "budget":
					Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
					break;

				case "basic":
					Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
					break;

				case "performant":
					Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
					break;

				case "high-end":
					Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
					break;

				default:
					Console.WriteLine("You did not choose a correct PC type");
					break;

			}
		}
    }
}
