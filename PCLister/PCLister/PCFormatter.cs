using System;

namespace PCLister
{
	public class PCFormatter
	{
		internal void Display(PC pc, string format)
		{
			switch (format)
			{
				case "min":
					Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
					break;

				case "full":

				case "budget":
					Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + " " + pc.MotherboardModel + " " + ", Ram slots " + pc.MotherBoardRamSlots + ", USB Ports: " + pc.MotherboardUsbPort + "\nProcessor: " + pc.ProcessorMake + "" + pc.ProcessorModel + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nProcessor cores: " + pc.ProcessorCores + "\nRam: " + pc.RamSize + " " + pc.RamFrequency + "\nGraphic Card :" + pc.GraphicCardMake + " " + pc.GraphicCardModel + " " + pc.GraphicCardSyze + " " + pc.GraphicCardFrequency + "\nHDD:" + pc.MemoryHDD + "\nAudio card: " + pc.AudioCard);
					break;

				case "id":
					Console.WriteLine("ID_" + pc.MotherboardMake + "_" + pc.ProcessorMake + "_" + pc.ProcessorFrequency);
					break;

				default:
					Console.WriteLine("You did not choose a correct Display");
					break;
			}
		}
	}
}