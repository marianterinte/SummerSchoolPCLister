using System;

namespace PCLister
{
	public abstract class PCBuilder
	{
		protected PC pc;
		public PC GetPC()
		{
			return pc;
		}

		public virtual void Build()
		{
			pc = new PC();

			SetupMotherboard();
			SetupMemory();
			SetupProcessor();
			SetupStorage();
			SetupGpu();
			SetupAudioCard();
		}

		protected abstract void SetupMemory();

		protected abstract void SetupMotherboard();

		protected abstract void SetupGpu();
		protected abstract void SetupProcessor();
		protected abstract void SetupStorage();
		protected abstract void SetupAudioCard();

	}
}
