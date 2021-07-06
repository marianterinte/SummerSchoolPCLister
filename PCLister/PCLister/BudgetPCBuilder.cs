﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class BudgetPCBuilder : PCBuilder
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
			throw new NotImplementedException();
		}

		protected override void SetupMotherboard()
		{
			throw new NotImplementedException();
		}
	}
}
