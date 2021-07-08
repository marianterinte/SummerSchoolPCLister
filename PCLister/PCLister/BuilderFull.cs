using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
    class BuilderFull
    {
         PC pc;
        
      public void Display(string format)
        {
			switch (format)
			{
				case "budget":
					Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + " " + pc.MotherboardModel + " " + ", Ram slots " + pc.MotherBoardRamSlots + ", USB Ports: " + pc.MotherboardUsbPort + "\nProcessor: " + pc.ProcessorMake + "" + pc.ProcessorModel + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nProcessor cores: " + pc.ProcessorCores + "\nRam: " + pc.RamSize + " " + pc.RamFrequency + "\nGraphic Card :" + pc.GraphicCardMake + " " + pc.GraphicCardModel + " " + pc.GraphicCardSyze + " " + pc.GraphicCardFrequency + "\nHDD:" + pc.MemoryHDD + "\nAudio card: " + pc.AudioCard);
					break;

				case "basic":
					Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + " " + pc.MotherboardModel + " " + ", Ram slots " + pc.MotherBoardRamSlots + ", USB Ports: " + pc.MotherboardUsbPort + "\nProcessor: " + pc.ProcessorMake + " " + pc.ProcessorModel + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nProcessor cores: " + pc.ProcessorCores + "\nRam: " + pc.RamSize + " " + pc.RamFrequency + "\nGraphic Card :" + pc.GraphicCardMake + " " + pc.GraphicCardModel + " " + pc.GraphicCardSyze + " " + pc.GraphicCardFrequency + "\nHDD:" + pc.MemoryHDD + "\nAudio card: " + pc.AudioCard);
					break;

				case "performant":
					Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + " " + pc.MotherboardModel + " " + ", Ram slots " + pc.MotherBoardRamSlots + ", USB Ports: " + pc.MotherboardUsbPort + "\nProcessor: " + pc.ProcessorMake + " " + pc.ProcessorModel + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nProcessor cores: " + pc.ProcessorCores + "\nRam: " + pc.RamSize + " " + pc.RamFrequency + "\nGraphic Card :" + pc.GraphicCardMake + " " + pc.GraphicCardModel + " " + pc.GraphicCardSyze + " " + pc.GraphicCardFrequency + "\nHDD:" + pc.MemoryHDD + "\nAudio card: " + pc.AudioCard);
					break;

				case "high-end":
					Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + " " + pc.MotherboardModel + " " + ", Ram slots " + pc.MotherBoardRamSlots + ", USB Ports: " + pc.MotherboardUsbPort + "\nProcessor: " + pc.ProcessorMake + " " + pc.ProcessorModel + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nProcessor cores: " + pc.ProcessorCores + "\nRam: " + pc.RamSize + " " + pc.RamFrequency + "\nGraphic Card :" + pc.GraphicCardMake + " " + pc.GraphicCardModel + " " + pc.GraphicCardSyze + " " + pc.GraphicCardFrequency + "\nHDD:" + pc.MemoryHDD + "\nAudio card: " + pc.AudioCard);
					break;

				default:
					Console.WriteLine("You did not choose a correct PC type");
					break;

			}
		}
    }
}
