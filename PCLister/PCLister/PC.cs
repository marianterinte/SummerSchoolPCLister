using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class PC
	{
		public string motherboardMake;
        public string motherboardModel;
        public string motherboardUsbPort;
        public string processorMake;
        public string processorModel;
		public string processorFrequency;
        public string processorCores;
        public string ramSize;
		public string ramFrequency;
		public string graphicCardMake;
        public string graphicCardModel;
        public string graphicCardSyze;
		public string graphicCardFrequency;
		public string memoryHDD; 
		public string motherBoardRamSlots;
		public string audioCard;

        public PC(string motherboardMake, string motherboardModel, string motherboardUsbPort, string processorMake, string processorModel, string processorFrequency, string processorCores, string ramSize, string ramFrequency, string graphicCardMake, string graphicCardModel, string graphicCardSyze, string graphicCardFrequency, string memoryHDD, string motherBoardRamSlots, string audioCard)
        {
            this.motherboardMake = motherboardMake;
            this.motherboardModel = motherboardModel;
            this.motherboardUsbPort = motherboardUsbPort;
            this.processorMake = processorMake;
            this.processorModel = processorModel;
            this.processorFrequency = processorFrequency;
            this.processorCores = processorCores;
            this.ramSize = ramSize;
            this.ramFrequency = ramFrequency;
            this.graphicCardMake = graphicCardMake;
            this.graphicCardModel = graphicCardModel;
            this.graphicCardSyze = graphicCardSyze;
            this.graphicCardFrequency = graphicCardFrequency;
            this.memoryHDD = memoryHDD;
            this.motherBoardRamSlots = motherBoardRamSlots;
            this.audioCard = audioCard;
        }
    }
}