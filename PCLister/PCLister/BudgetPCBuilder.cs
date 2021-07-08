using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class BudgetPCBuilder : PCBuilder
	{
		public override void Build()
		{
			base.Build();
		}

        protected override void SetupGpu()
        {
            pc.GraphicCardMake = "Nvidia";
            pc.GraphicCardModel = "1030 Low Profile";
            pc.GraphicCardSyze = "2GB";
            pc.GraphicCardFrequency = "900Mhz";
        }

        protected override void SetupMemory()
		{
            pc.RamSize = "8GB";
            pc.RamFrequency = "3000Mhz";

        }

		protected override void SetupMotherboard() {
            pc.MotherboardMake = "ASRock";
            pc.MotherboardModel = "B450 PRO4";
            pc.MotherBoardRamSlots = "2";
            pc.MotherboardUsbPort = "3";
        }

        protected override void SetupProcessor()
        {
            pc.ProcessorMake = "AMD";
            pc.ProcessorModel = "Ryzen 3 2200g";
            pc.ProcessorFrequency = "3.1Ghz";
            pc.ProcessorCores = "4";
        }

        protected override void SetupStorage()
        {
            pc.MemoryHDD = "500GB";
        }
        protected override void SetupAudioCard()
        {
            pc.AudioCard = "No";
        }
    }
}
