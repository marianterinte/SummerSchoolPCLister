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
		}

		protected abstract void SetupMemory();

		protected abstract void SetupMotherboard();
	}
}
