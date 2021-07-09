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


		internal void Display(string format)
		{
			switch (format)
			{
				case "min":
					Console.WriteLine("PC components:" + "\nMotherboard: " + MotherboardMake + "\nProcessor: " + ProcessorMake + "\nProcessor Freq: " + ProcessorFrequency + "\nRam Size: " + RamSize + "\nGraphic Card :" + GraphicCardModel + "\nHDD:" + MemoryHDD);
					break;

				case "full":

				case "budget":
					Console.WriteLine("PC components:" + "\nMotherboard: " + MotherboardMake + " " + MotherboardModel + " " + ", Ram slots " + MotherBoardRamSlots + ", USB Ports: " + MotherboardUsbPort + "\nProcessor: " + ProcessorMake + "" + ProcessorModel + "\nProcessor Freq: " + ProcessorFrequency + "\nProcessor cores: " + ProcessorCores + "\nRam: " + RamSize + " " + RamFrequency + "\nGraphic Card :" + GraphicCardMake + " " + GraphicCardModel + " " + GraphicCardSyze + " " + GraphicCardFrequency + "\nHDD:" + MemoryHDD + "\nAudio card: " + AudioCard);
					break;

				case "id":
					Console.WriteLine("ID_" + MotherboardMake + "_" + ProcessorMake + "_" + ProcessorFrequency);
					break;

				default:
					Console.WriteLine("You did not choose a correct Display");
					break;
			}
		}
	}
}