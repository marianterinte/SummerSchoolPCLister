using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class PCBuilderFactory
	{
		Dictionary<string, BasePCBuilder> pcTypeBuilderMap = new Dictionary<string, BasePCBuilder>
		{
				{"budget", new BudgetPCBuilder() },
				{"basic", new BasicPCBuilder() },
				{"performant", new PerformantPCBuilder() },
				{"high-end", new HighEndPCBuilder() },
		};

		public BasePCBuilder Get(string pcType)
		{
			if (pcTypeBuilderMap.ContainsKey(pcType))
				return pcTypeBuilderMap[pcType];

			throw new Exception("PC Type not found!");
		}
	}
}
