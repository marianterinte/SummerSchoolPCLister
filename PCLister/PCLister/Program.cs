using System;

namespace PCLister
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("PC Type(budget/basic/performant/high-end): ");
			var pcType = Console.ReadLine();

			//Console.WriteLine("Processor: ");
			//var processorMake = Console.ReadLine();

			Console.WriteLine("Display (min/full/id): ");
			var format = Console.ReadLine();

			var pc = new PC("Asus", "PRIME B550M-A","5", "AMD","Ryzen 5 3600", "4Ghz", "6", "16GB", "3600Mhz", "Nvidia", "RTX 2060", "6GB", "1710Mhz", "1TB", "4", "Yes");
			var pc2 = new PC("Gigabyte", "X570 I AORUS PRO","8", "AMD","Ryzen 5950X", "5Ghz", "16", "32GB", "3600Mhz", "Nvidia", "RTX 3090", "24GB", "1950Mhz", "4TB", "8", "Yes");
			var pc3 = new PC("MSI", "B450-A PRO MAX","4", "Intel", "coffee lake core i3 9100", "3.8Ghz", "4", "8GB", "3200Mhz", "Radeon", "RX 5600", "6GB", "1500Mhz", "1TB", "4", "No");
			var pc4 = new PC("ASRock", "B450 PRO4","3", "AMD","Ryzen 3 2200g", "3.1Ghz", "4", "8GB", "3000Mhz", "Nvidia", "1030 Low Profile", "2GB", "900Mhz", "500GB", "2", "No");

					switch (format)
					{

						case "min":
							switch (pcType)
							{
								case "budget":
									Console.WriteLine("PC components:" + "\nMotherboard: " + pc4.motherboardMake + "\nProcessor: " + pc4.processorMake + "\nProcessor Freq: " + pc4.processorFrequency + "\nRam Size: " + pc4.ramSize + "\nGraphic Card :" + pc4.graphicCardModel + "\nHDD:" + pc4.memoryHDD);
									break;

								case "basic":
									Console.WriteLine("PC components:" + "\nMotherboard: " + pc3.motherboardMake + "\nProcessor: " + pc3.processorMake + "\nProcessor Freq: " + pc3.processorFrequency + "\nRam Size: " + pc3.ramSize + "\nGraphic Card :" + pc3.graphicCardModel + "\nHDD:" + pc3.memoryHDD);
									break;

								case "performant":
									Console.WriteLine("PC components:" + "\nMotherboard: " + pc.motherboardMake + "\nProcessor: " + pc.processorMake + "\nProcessor Freq: " + pc.processorFrequency + "\nRam Size: " + pc.ramSize + "\nGraphic Card :" + pc.graphicCardModel + "\nHDD:" + pc.memoryHDD);
									break;

								case "high-end":
									Console.WriteLine("PC components:" + "\nMotherboard: " + pc2.motherboardMake + "\nProcessor: " + pc2.processorMake + "\nProcessor Freq: " + pc2.processorFrequency + "\nRam Size: " + pc2.ramSize + "\nGraphic Card :" + pc2.graphicCardModel + "\nHDD:" + pc2.memoryHDD);
									break;

								default:
									Console.WriteLine("You did not choose a correct PC type");
									break;

							}
							break;

						case "full":
							switch (pcType)
							{
								case "budget":
									Console.WriteLine("PC components:" + "\nMotherboard: " + pc4.motherboardMake + " " + pc4.motherboardModel + " " + ", Ram slots " + pc4.motherBoardRamSlots +", USB Ports: "+pc4.motherboardUsbPort + "\nProcessor: " + pc4.processorMake +""+pc4.processorModel+ "\nProcessor Freq: " + pc4.processorFrequency + "\nProcessor cores: " + pc4.processorCores + "\nRam: " + pc4.ramSize + " " + pc4.ramFrequency + "\nGraphic Card :" + pc4.graphicCardMake + " " + pc4.graphicCardModel + " " + pc4.graphicCardSyze + " " + pc4.graphicCardFrequency + "\nHDD:" + pc4.memoryHDD + "\nAudio card: " + pc4.audioCard);
									break;

								case "basic":
									Console.WriteLine("PC components:" + "\nMotherboard: " + pc3.motherboardMake + " " + pc3.motherboardModel + " " + ", Ram slots " + pc3.motherBoardRamSlots + ", USB Ports: " + pc3.motherboardUsbPort + "\nProcessor: " + pc3.processorMake+" "+pc3.processorModel + "\nProcessor Freq: " + pc3.processorFrequency + "\nProcessor cores: " + pc3.processorCores + "\nRam: " + pc3.ramSize + " " + pc3.ramFrequency + "\nGraphic Card :" + pc3.graphicCardMake + " " + pc3.graphicCardModel + " " + pc3.graphicCardSyze + " " + pc3.graphicCardFrequency + "\nHDD:" + pc3.memoryHDD + "\nAudio card: " + pc3.audioCard);
									break;

								case "performant":
									Console.WriteLine("PC components:" + "\nMotherboard: " + pc.motherboardMake + " " + pc.motherboardModel + " " + ", Ram slots " + pc.motherBoardRamSlots + ", USB Ports: " + pc.motherboardUsbPort + "\nProcessor: " + pc.processorMake +" "+pc.processorModel+ "\nProcessor Freq: " + pc.processorFrequency + "\nProcessor cores: " + pc.processorCores + "\nRam: " + pc.ramSize + " " + pc.ramFrequency + "\nGraphic Card :" + pc.graphicCardMake + " " + pc.graphicCardModel + " " + pc.graphicCardSyze + " " + pc.graphicCardFrequency + "\nHDD:" + pc.memoryHDD + "\nAudio card: " + pc.audioCard);
									break;

								case "high-end":
									Console.WriteLine("PC components:" + "\nMotherboard: " + pc2.motherboardMake + " " + pc2.motherboardModel + " " + ", Ram slots " + pc2.motherBoardRamSlots + ", USB Ports: " + pc2.motherboardUsbPort + "\nProcessor: " + pc2.processorMake +" "+pc2.processorModel+ "\nProcessor Freq: " + pc2.processorFrequency + "\nProcessor cores: " + pc2.processorCores + "\nRam: " + pc2.ramSize + " " + pc2.ramFrequency + "\nGraphic Card :" + pc2.graphicCardMake + " " + pc2.graphicCardModel + " " + pc2.graphicCardSyze + " " + pc2.graphicCardFrequency + "\nHDD:" + pc2.memoryHDD + "\nAudio card: " + pc2.audioCard);
									break;

								default:
									Console.WriteLine("You did not choose a correct PC type");
									break;

							}
							break;

						case "id":
							switch (pcType)
							{
								case "budget":
									Console.WriteLine("ID_" + pc4.motherboardMake + "_" + pc4.processorMake + "_" + pc4.processorFrequency);
									break;

								case "basic":
									Console.WriteLine("ID_" + pc3.motherboardMake + "_" + pc3.processorMake + "_" + pc3.processorFrequency);
									break;

								case "performant":
									Console.WriteLine("ID_" + pc.motherboardMake + "_" + pc.processorMake + "_" + pc.processorFrequency);
									break;

								case "high-end":
									Console.WriteLine("ID_" + pc2.motherboardMake + "_" + pc2.processorMake + "_" + pc2.processorFrequency);
									break;

								default:
									Console.WriteLine("You did not choose a correct PC type");
									break;

							}
							break;

						default:
							Console.WriteLine("You did not choose a correct Display");
							break;
					}

		}


		//basic
		//AMD
		//min

		// Motherboard: Asus
		// Processor: AMD
		// Processor Freq: 4Ghz
		// Ram Size: 16GB
		// Ram Freq: 3600 Mhz

	}
}
