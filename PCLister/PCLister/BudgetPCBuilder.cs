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
            pc.GraphicCardMake = "AMD";
            pc.GraphicCardModel = "Radeon Vega 11";
            pc.GraphicCardSize = "2GB";
        }

        protected override void SetupMemory()
        {
            pc.RamSize = "16GB";
            pc.RamFrequency = "3000Mhz";

        }

        protected override void SetupMotherboard()
        {
            pc.MotherboardMake = "AMD";
            pc.MotherboardModel = "B450";
            pc.MotherBoardRamSlots = "4";
        }

        protected override void SetupProcessor()
        {
            pc.ProcessorMake = "AMD";
            pc.ProcessorModel = "Ryzen 5 3400G";
            pc.ProcessorFrequency = "3.7Ghz";
            pc.ProcessorCores = "4";
        }

        protected override void SetupStorage()
        {
            pc.MemoryHDD = "250GB";
        }
    }
}