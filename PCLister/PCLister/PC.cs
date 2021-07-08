using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class PC
	{
		private string motherboardMake;
		private string motherboardModel;
		private string motherboardUsbPort;
		private string processorMake;
		private string processorModel;
		private string processorFrequency;
		private string processorCores;
		private string ramSize;
		private string ramFrequency;
		private string graphicCardMake;
		private string graphicCardModel;
		private string graphicCardSyze;
		private string graphicCardFrequency;
		private string memoryHDD;
		private string motherBoardRamSlots;
		private string audioCard;

		public string MotherboardMake { get => motherboardMake; set => motherboardMake = value; }
		public string MotherboardModel { get => motherboardModel; set => motherboardModel = value; }
		public string MotherboardUsbPort { get => motherboardUsbPort; set => motherboardUsbPort = value; }
		public string ProcessorMake { get => processorMake; set => processorMake = value; }
		public string ProcessorModel { get => processorModel; set => processorModel = value; }
		public string ProcessorFrequency { get => processorFrequency; set => processorFrequency = value; }
		public string ProcessorCores { get => processorCores; set => processorCores = value; }
		public string RamSize { get => ramSize; set => ramSize = value; }
		public string RamFrequency { get => ramFrequency; set => ramFrequency = value; }
		public string GraphicCardMake { get => graphicCardMake; set => graphicCardMake = value; }
		public string GraphicCardModel { get => graphicCardModel; set => graphicCardModel = value; }
		public string GraphicCardSyze { get => graphicCardSyze; set => graphicCardSyze = value; }
		public string GraphicCardFrequency { get => graphicCardFrequency; set => graphicCardFrequency = value; }
		public string MemoryHDD { get => memoryHDD; set => memoryHDD = value; }
		public string MotherBoardRamSlots { get => motherBoardRamSlots; set => motherBoardRamSlots = value; }
		public string AudioCard { get => audioCard; set => audioCard = value; }
		public void PrintSpecs(string format)
        {
			string output = "";
			switch (format)
			{
				case "min":
					output += "PC components:\n";
					output += "Motherboard: " + MotherboardMake + "\n";
					output += "Processor: " + ProcessorMake + "\n";
					output += "Processor Freq: " + ProcessorFrequency + "\n";
					output += "Ram Size: " + RamSize + "\n";
					output += "Graphic Card :" + GraphicCardModel + "\n";
					output += "HDD:" + MemoryHDD + "\n";
					break;

				case "full":
					output += "PC components:\n";
					output += "Motherboard: " + MotherboardMake + " " + MotherboardModel + " , Ram slots " + MotherBoardRamSlots + ", USB Ports: " + MotherboardUsbPort + "\n";
					output += "Processor: " + ProcessorMake + "" + ProcessorModel + "\n";
					output += "Processor Freq: " + ProcessorFrequency + "\n";
					output += "Processor cores: " + ProcessorCores + "\n";
					output += "Ram: " + RamSize + " " + RamFrequency + "\n";
					output += "Graphic Card :" + GraphicCardMake + " " + GraphicCardModel + " " + GraphicCardSyze + " " + GraphicCardFrequency + "\n";
					output += "HDD:" + MemoryHDD + "\n";
					output += "Audio card: " + AudioCard + "\n";
					break;

				case "id":
					output = "ID_" + MotherboardMake + "_" + ProcessorMake + "_" + ProcessorFrequency;
					break;
				default:
					output = "You did not choose a correct Display";
					break;
			}
			Console.WriteLine(output);
		}
	}
}