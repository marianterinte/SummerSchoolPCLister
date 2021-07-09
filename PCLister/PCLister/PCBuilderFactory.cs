using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class PCBuilderFactory
	{
		public PCBuilder Get(string pcType)
		{
			switch (pcType)
			{
				case "basic":
					{
						return new BasicPCBuilder();
					}

				case "performant":
					{
						return new PerformantPCBuilder();
					}

				case "high-end":
					{
						return new HighEndPCBuilder();
					}

				default:
					{
						return new BudgetPCBuilder();
					}
			}
		}
	}
}
