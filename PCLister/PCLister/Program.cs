using System;

namespace PCLister
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("PC Type(budget/basic/performant/high-end): ");
			var pcType = Console.ReadLine();

			Console.WriteLine("Display (min/full/id): ");

			var format = Console.ReadLine();
			PCBuilder pcBuilder;
		
			
			switch (pcType)
			{
				case "basic":
					{
						pcBuilder = new BasicPCBuilder();
						break;
					}

				case "performant":
					{
						pcBuilder = new PerformantPCBuilder();
						break;
					}

				case "high-end":
					{
						pcBuilder = new HighEndPCBuilder();
						break;
					}

				default:
					{
						pcBuilder = new BudgetPCBuilder();
						break;

					}
			}

			pcBuilder.Build();
			PC pc = pcBuilder.GetPC()

			class budget : pcType
		
			{
				Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
			}
		class basic : pcType

		{
			Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
			}
		class performant : pcType

		{
			Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
			}
		class high-end : pcType

		{
			Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
			}

			switch (format)
			{
				case "min":
					switch (pcType)
					{
						case "budget":
							Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
							break;

						case "basic":
							Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
							break;

						case "performant":
							Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
							break;

						case "high-end":
							Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + "\nProcessor: " + pc.ProcessorMake + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nRam Size: " + pc.RamSize + "\nGraphic Card :" + pc.GraphicCardModel + "\nHDD:" + pc.MemoryHDD);
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
							Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + " " + pc.MotherboardModel + " " + ", Ram slots " + pc.MotherBoardRamSlots + ", USB Ports: " + pc.MotherboardUsbPort + "\nProcessor: " + pc.ProcessorMake + "" + pc.ProcessorModel + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nProcessor cores: " + pc.ProcessorCores + "\nRam: " + pc.RamSize + " " + pc.RamFrequency + "\nGraphic Card :" + pc.GraphicCardMake + " " + pc.GraphicCardModel + " " + pc.GraphicCardSyze + " " + pc.GraphicCardFrequency + "\nHDD:" + pc.MemoryHDD + "\nAudio card: " + pc.AudioCard);
							break;

						case "basic":
							Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + " " + pc.MotherboardModel + " " + ", Ram slots " + pc.MotherBoardRamSlots + ", USB Ports: " + pc.MotherboardUsbPort + "\nProcessor: " + pc.ProcessorMake + " " + pc.ProcessorModel + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nProcessor cores: " + pc.ProcessorCores + "\nRam: " + pc.RamSize + " " + pc.RamFrequency + "\nGraphic Card :" + pc.GraphicCardMake + " " + pc.GraphicCardModel + " " + pc.GraphicCardSyze + " " + pc.GraphicCardFrequency + "\nHDD:" + pc.MemoryHDD + "\nAudio card: " + pc.AudioCard);
							break;

						case "performant":
							Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + " " + pc.MotherboardModel + " " + ", Ram slots " + pc.MotherBoardRamSlots + ", USB Ports: " + pc.MotherboardUsbPort + "\nProcessor: " + pc.ProcessorMake + " " + pc.ProcessorModel + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nProcessor cores: " + pc.ProcessorCores + "\nRam: " + pc.RamSize + " " + pc.RamFrequency + "\nGraphic Card :" + pc.GraphicCardMake + " " + pc.GraphicCardModel + " " + pc.GraphicCardSyze + " " + pc.GraphicCardFrequency + "\nHDD:" + pc.MemoryHDD + "\nAudio card: " + pc.AudioCard);
							break;

						case "high-end":
							Console.WriteLine("PC components:" + "\nMotherboard: " + pc.MotherboardMake + " " + pc.MotherboardModel + " " + ", Ram slots " + pc.MotherBoardRamSlots + ", USB Ports: " + pc.MotherboardUsbPort + "\nProcessor: " + pc.ProcessorMake + " " + pc.ProcessorModel + "\nProcessor Freq: " + pc.ProcessorFrequency + "\nProcessor cores: " + pc.ProcessorCores + "\nRam: " + pc.RamSize + " " + pc.RamFrequency + "\nGraphic Card :" + pc.GraphicCardMake + " " + pc.GraphicCardModel + " " + pc.GraphicCardSyze + " " + pc.GraphicCardFrequency + "\nHDD:" + pc.MemoryHDD + "\nAudio card: " + pc.AudioCard);
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
							Console.WriteLine("ID_" + pc.MotherboardMake + "_" + pc.ProcessorMake + "_" + pc.ProcessorFrequency);
							break;

						case "basic":
							Console.WriteLine("ID_" + pc.MotherboardMake + "_" + pc.ProcessorMake + "_" + pc.ProcessorFrequency);
							break;

						case "performant":
							Console.WriteLine("ID_" + pc.MotherboardMake + "_" + pc.ProcessorMake + "_" + pc.ProcessorFrequency);
							break;

						case "high-end":
							Console.WriteLine("ID_" + pc.MotherboardMake + "_" + pc.ProcessorMake + "_" + pc.ProcessorFrequency);
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
	}
}
