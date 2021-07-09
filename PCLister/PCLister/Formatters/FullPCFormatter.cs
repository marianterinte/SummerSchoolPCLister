using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister.Formatters
{
	public class FullPCFormatter : IPCFormatter
	{
		public void Display(PC pc)
		{
			Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + " " + pc.MotherboardModel + " " + ", Ram slots " + pc.MotherBoardRamSlots + ", USB Ports: " + pc.MotherboardUsbPort + "\nProcessor: " + pc.ProcessorMake + "" + pc.ProcessorModel + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nProcessor cores: " + pc.ProcessorCores + "\nRam: " + pc.RamSize + " " + pc.RamFrequency + "\nGraphic Card :" + pc.GraphicCardMake + " " + pc.GraphicCardModel + " " + pc.GraphicCardSyze + " " + pc.GraphicCardFrequency + "\nHDD:" + pc.MemoryHDD + "\nAudio card: " + pc.AudioCard);
		}
	}
}
