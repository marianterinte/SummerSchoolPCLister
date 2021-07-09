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
            pc.GraphicCardMake = "Intel";
            pc.GraphicCardModel = "UHD Graphics 630";
            pc.GraphicCardSize = "4GB";
        }

        protected override void SetupMemory()
        {
            pc.RamSize = "8GB";
            pc.RamFrequency = "2666Mhz";

        }

        protected override void SetupMotherboard()
        {
            pc.MotherboardMake = "Intel";
            pc.MotherboardModel = "CM246";
            pc.MotherBoardRamSlots = "4";
        }

        protected override void SetupProcessor()
        {
            pc.ProcessorMake = "Intel";
            pc.ProcessorModel = "Core i7 9750H";
            pc.ProcessorFrequency = "2.6Ghz";
            pc.ProcessorCores = "6";
        }

        protected override void SetupStorage()
        {
            pc.MemoryHDD = "1TB";
        }
    }
}