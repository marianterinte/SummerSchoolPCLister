using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class PC
	{
		private string motherboardMake;
		private string motherboardModel;
		private string processorMake;
		private string processorModel;
		private string processorFrequency;
		private string processorCores;
		private string ramSize;
		private string ramFrequency;
		private string graphicCardMake;
		private string graphicCardModel;
		private string graphicCardSize;
		private string memoryHDD;
		private string motherBoardRamSlots;

		public string MotherboardMake { get => motherboardMake; set => motherboardMake = value; }
		public string MotherboardModel { get => motherboardModel; set => motherboardModel = value; }
		public string ProcessorMake { get => processorMake; set => processorMake = value; }
		public string ProcessorModel { get => processorModel; set => processorModel = value; }
		public string ProcessorFrequency { get => processorFrequency; set => processorFrequency = value; }
		public string ProcessorCores { get => processorCores; set => processorCores = value; }
		public string RamSize { get => ramSize; set => ramSize = value; }
		public string RamFrequency { get => ramFrequency; set => ramFrequency = value; }
		public string GraphicCardMake { get => graphicCardMake; set => graphicCardMake = value; }
		public string GraphicCardModel { get => graphicCardModel; set => graphicCardModel = value; }
		public string GraphicCardSyze { get => graphicCardSize; set => graphicCardSize = value; }
		public string MemoryHDD { get => memoryHDD; set => memoryHDD = value; }
	}
}