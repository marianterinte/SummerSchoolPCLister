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

			pc.MotherboardMake = "Asus";
			pc.MotherboardModel = "PRIME B550M-A";
			pc.MotherBoardRamSlots = "5";
			pc.ProcessorMake = "AMD";
			pc.ProcessorModel = "Ryzen 5 3600";
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
