using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class BudgetPCBuilder : BasePCBuilder
	{
		public override void Build()
		{
			base.Build();
			
			pc.MotherboardMake = "ASRock";
			pc.MotherboardModel = "B450 PRO4";
			pc.MotherBoardRamSlots = "3";
			pc.ProcessorMake = "AMD";
			pc.ProcessorModel = "Ryzen 3 2200g";
		}

		protected override void SetupMemory()
		{
		}

		protected override void SetupMotherboard()
		{
		}
	}
}
