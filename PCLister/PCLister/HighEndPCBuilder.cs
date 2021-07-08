using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class HighEndPCBuilder : PCBuilder
	{
		public override void Build()
		{
			base.Build();
		}

        protected override void SetupGpu()
        {
            pc.GraphicCardMake = "Nvidia";
            pc.GraphicCardModel = "RTX 3090";
            pc.GraphicCardSyze = "24GB";
            pc.GraphicCardFrequency = "1950Mhz";
        }

        protected override void SetupMemory()
        {
            pc.RamSize = "32GB";
            pc.RamFrequency = "3600Mhz";

        }

        protected override void SetupMotherboard()
        {
            pc.MotherboardMake = "Gigabyte";
            pc.MotherboardModel = "X570 I AORUS PRO";
            pc.MotherBoardRamSlots = "8";
            pc.MotherboardUsbPort = "8";
        }

        protected override void SetupProcessor()
        {
            pc.ProcessorMake = "AMD";
            pc.ProcessorModel = "Ryzen 5950X";
            pc.ProcessorFrequency = "5Ghz";
            pc.ProcessorCores = "16";
        }

        protected override void SetupStorage()
        {
            pc.MemoryHDD = "4TB";
        }
        protected override void SetupAudioCard()
        {
            pc.AudioCard = "Yes";
        }
    }
}
