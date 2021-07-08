using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class BasicPCBuilder : PCBuilder
	{
		public BasicPCBuilder()
		{
		}

		public override void Build()
		{
			base.Build();
		}
        protected override void SetupGpu()
        {
            pc.GraphicCardMake = "Radeon";
            pc.GraphicCardModel = "RX 5600";
            pc.GraphicCardSyze = "6GB";
            pc.GraphicCardFrequency = "1500Mhz";
        }

        protected override void SetupMemory()
        {
            pc.RamSize = "8GB";
            pc.RamFrequency = "3200Mhz";

        }

        protected override void SetupMotherboard()
        {
            pc.MotherboardMake = "MSI";
            pc.MotherboardModel = "B450-A PRO MAX";
            pc.MotherBoardRamSlots = "4";
            pc.MotherboardUsbPort = "4";
        }

        protected override void SetupProcessor()
        {
            pc.ProcessorMake = "Intel";
            pc.ProcessorModel = "coffee lake core i3 9100";
            pc.ProcessorFrequency = "3.8Ghz";
            pc.ProcessorCores = "4";
        }

        protected override void SetupStorage()
        {
            pc.MemoryHDD = "1TB";
        }
        protected override void SetupAudioCard()
        {
            pc.AudioCard = "No";
        }
    }
}
