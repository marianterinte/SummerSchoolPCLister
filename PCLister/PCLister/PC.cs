using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml;

namespace PCLister
{
	public class PC
	{
		public enum printSpecsFormat
        {
			Null,
			Min,
			Full,
			Id
        }

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

		static public printSpecsFormat convertInput(string input)
        {
			printSpecsFormat printSpecsEnum = printSpecsFormat.Null;
			try
			{
				printSpecsEnum = (printSpecsFormat)Enum.Parse(typeof(printSpecsFormat), input, true);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return printSpecsEnum;
		}

		public void printSpecs(printSpecsFormat format)
        {
			switch (format)
			{
				case printSpecsFormat.Min:
					Console.WriteLine("Motherboard: " + motherboardMake);
					Console.WriteLine("Processor: " + processorMake);
					Console.WriteLine("Processor Freq: " + processorFrequency);
					Console.WriteLine("Ram Size: " + ramSize);
					Console.WriteLine("Ram Frequency: " + ramFrequency);
					break;

				case printSpecsFormat.Full:
					Console.WriteLine(JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented));
					break;

				case printSpecsFormat.Id:
					string unit = ramFrequency.Substring(ramFrequency.Length - 3);
					float value = float.Parse(ramFrequency.Substring(0,ramFrequency.IndexOf(unit)));
					if (unit == "Mhz")
					{ 
						value /= 1000; 
					}
					Console.WriteLine($"ID_{motherboardMake.Substring(0, 2).ToUpper()}_{processorMake.ToUpper()}_{value}_GHZ");
					break;

				default:
					Console.WriteLine("Error");
					break;
            }
        }
	}
}
