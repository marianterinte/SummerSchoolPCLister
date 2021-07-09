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
            pc.GraphicCardModel = "RTX 3060";
            pc.GraphicCardSize = "12 GB";
        }

        protected override void SetupMemory()
        {
            pc.RamSize = "16GB";
            pc.RamFrequency = "3000Mhz";

        }

        protected override void SetupMotherboard()
        {
            pc.MotherboardMake = "AMD";
            pc.MotherboardModel = "B550";
            pc.MotherBoardRamSlots = "4";
        }

        protected override void SetupProcessor()
        {
            pc.ProcessorMake = "AMD";
            pc.ProcessorModel = "3600";
            pc.ProcessorFrequency = "3.6Ghz";
            pc.ProcessorCores = "6";
        }

        protected override void SetupStorage()
        {
            pc.MemoryHDD = "1TB";
        }
    }
}