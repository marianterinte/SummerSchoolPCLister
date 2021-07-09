using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class BasicPCBuilder : BasePCBuilder
	{
		public BasicPCBuilder()
		{
		}

		public override void Build()
		{
			base.Build();
		
			pc.MotherBoardRamSlots = "3";
			pc.ProcessorMake = "Intel";
			pc.ProcessorModel = "coffee lake core i3 9100";
		}

		protected override void SetupMemory()
		{
			 
		}

		protected override void SetupMotherboard()
		{
			pc.MotherboardMake = "MSI";
			pc.MotherboardModel = "B450-A PRO MAX";
		}
	}
}
