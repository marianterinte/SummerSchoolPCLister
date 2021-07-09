using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class HighEndPCBuilder : BasePCBuilder
	{
		public override void Build()
		{
			base.Build();

			pc.MotherboardMake = "Gigabyte";
			pc.MotherboardModel = "X570 I AORUS PRO";
			pc.MotherBoardRamSlots = "8";
			pc.ProcessorMake = "AMD";
			pc.ProcessorModel = "Ryzen 5950X";
		}

		protected override void SetupMemory()
		{
			throw new NotImplementedException();
		}

		protected override void SetupMotherboard()
		{
			throw new NotImplementedException();
		}
	}
}
