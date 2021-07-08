using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class PerformantPCBuilder : PCBuilder
	{
		public override void Build()
		{
			base.Build();
		}

        protected override void SetupGpu()
        {
            pc.GraphicCardMake = "Nvidia";
            pc.GraphicCardModel = "RTX 2060";
            pc.GraphicCardSyze = "6GB";
            pc.GraphicCardFrequency = "1710Mhz";
        }

        protected override void SetupMemory()
        {
            pc.RamSize = "16GB";
            pc.RamFrequency = "3600Mhz";

        }

        protected override void SetupMotherboard()
        {
            pc.MotherboardMake = "Asus";
            pc.MotherboardModel = "PRIME B550M-A";
            pc.MotherBoardRamSlots = "4";
            pc.MotherboardUsbPort = "5";
        }

        protected override void SetupProcessor()
        {
            pc.ProcessorMake = "AMD";
            pc.ProcessorModel = "Ryzen 5 3600";
            pc.ProcessorFrequency = "4Ghz";
            pc.ProcessorCores = "6";
        }

        protected override void SetupStorage()
        {
            pc.MemoryHDD = "1TB";
        }
        protected override void SetupAudioCard()
        {
            pc.AudioCard = "Yes";
        }
    }
}
