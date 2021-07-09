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
            pc.GraphicCardMake = "Asus";
            pc.GraphicCardModel = "GTX 1650";
            pc.GraphicCardSize = "4GB";
        }

        protected override void SetupMemory()
        {
            pc.RamSize = "16GB";
            pc.RamFrequency = "2666Mhz";

        }

        protected override void SetupMotherboard()
        {
            pc.MotherboardMake = "Asus";
            pc.MotherboardModel = "PRIME H410M-K";
            pc.MotherBoardRamSlots = "4";
        }

        protected override void SetupProcessor()
        {
            pc.ProcessorMake = "Intel";
            pc.ProcessorModel = "i5 10400F";
            pc.ProcessorFrequency = "2.9Ghz";
            pc.ProcessorCores = "6";
        }

        protected override void SetupStorage()
        {
            pc.MemoryHDD = "1TB";
        }
    }
}