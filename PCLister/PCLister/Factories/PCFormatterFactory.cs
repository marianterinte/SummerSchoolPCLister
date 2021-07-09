using PCLister.Formatters;
using System;
using System.Collections.Generic;

namespace PCLister
{
	public class PCFormatterFactory
	{
		Dictionary<string, IPCFormatter> pcFormatter = new Dictionary<string, IPCFormatter>
		{
				{"min", new MinPCFormatter() },
				{"full", new FullPCFormatter() },
				{"id", new IdPCFormatter() },
		};

		public IPCFormatter Get(string format)
		{
			if (pcFormatter.ContainsKey(format))
				return pcFormatter[format];

			throw new Exception("format not found!");
		}
	}
}
