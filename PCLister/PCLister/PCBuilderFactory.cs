using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class PCBuilderFactory
	{
		Dictionary<string, PCBuilder> pcTypeBuilderMap = new Dictionary<string, PCBuilder>
		{
				{"budget", new BudgetPCBuilder() },
				{"basic", new BasicPCBuilder() },
				{"performant", new PerformantPCBuilder() },
				{"high-end", new HighEndPCBuilder() },
		};

		public PCBuilder Get(string pcType)
		{
			if (pcTypeBuilderMap.ContainsKey(pcType))
				return pcTypeBuilderMap[pcType];

			throw new Exception("PC Type not found!");
		}
	}
}
