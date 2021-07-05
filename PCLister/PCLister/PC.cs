using System;
using System.Collections.Generic;
using System.Text;

namespace PCLister
{
	public class PC
	{
		public string motherboardMake;
		public string processorMake;
		public string processorFrequency;
		public string ramSize;
		public string ramFrequency;

		public PC(string motherboardMake, string processorMake, string processorFrequency, string ramSize, string ramFrequency)
		{
			this.motherboardMake = motherboardMake;
			this.processorMake = processorMake;
			this.processorFrequency = processorFrequency;
			this.ramSize = ramSize;
			this.ramFrequency = ramFrequency;
		}
	}
}
