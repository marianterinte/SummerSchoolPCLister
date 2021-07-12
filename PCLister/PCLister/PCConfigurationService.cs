using System;

namespace PCLister
{
	public class PCConfigurationService
	{
		private string pcType;
		IPCFormatter pcFormatter;

		public PCConfigurationService(string pcType)
		{
			this.pcType = pcType;
		}

		private PC GetBuildedPC()
		{
			var pcBuilderFactory = new PCBuilderFactory();
			BasePCBuilder pcBuilder = pcBuilderFactory.Get(pcType);

			pcBuilder.Build();
			PC pc = pcBuilder.GetPC();

			return pc;
		}

		public void SetFormatter(IPCFormatter pcFormatter)
		{
			this.pcFormatter = pcFormatter;
		}

		public void Display()
		{
			pcFormatter.Display(GetBuildedPC());
		}
	}
}