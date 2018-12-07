using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSEngine
{
    public class RPSEngineMain
    {
		static void WriteRPS(int rps)
		{
			if (rps == 1)
			{
				Console.Write("Rock");
			}
			if (rps == 2)
			{
				Console.Write("Paper");
			}
			if (rps == 3)
			{
				Console.Write("Scissors");
			}
			if (rps == 4)
			{
				Console.Write("Mustard Gas");
			}
			if (rps == 5)
			{
				Console.Write("MG-42 Machine Gun");
			}
			if (rps == 6)
			{
				Console.Write("IL-2 Sturmovik Fighter Plane");
			}
			if(rps == 7)
			{
				Console.Write("Gas Mask");
			}
			if(rps == 8)
			{
				Console.Write("Anti-Aircraft Battery");
			}
		}

		static int ReadRPS()
		{
			while (true)
			{
				Console.WriteLine("1 - Rock");
				Console.WriteLine("2 - Paper");
				Console.WriteLine("3 - Scissors");
				Console.WriteLine("4 - MG-42 Machine Gun");
				Console.WriteLine("5 - Mustard Gas");
				Console.WriteLine("6 - IL-2 Sturmovik Aircraft");
				Console.WriteLine("7 - Gas Mask");
				Console.WriteLine("8 - Anti-Aircraft Battery");
				Console.Write("Please Pick: ");

				string input = Console.ReadLine();
				if (input == "1")
				{
					return 1;
				}
				if (input == "2")
				{
					return 2;
				}
				if (input == "3")
				{
					return 3;
				}
				if (input == "4")
				{
					return 4;
				}
				if (input == "5")
				{
					return 5;
				}
				if (input == "6")
				{
					return 6;
				}
				if (input == "7")
				{
					return 7;
				}
				if (input == "8")
				{
					return 8;
				}
				//Creation of computer's choice
				Random rnd = new Random();
				int computerChoice = rnd.Next(8) + 1;
				//To be put into new function

				Console.WriteLine("Invalid input");
				Console.WriteLine();
			}
			
		}

		static bool CompareRPS(int x, int y)
		{
			//Rock - 1
			//Paper - 2
			//Scissors - 3
			//if x is stronger than y return true

			if (x == 1) //rock
			{
				if (y == 2) //paper
				{
					return false;
				}
				if (y == 3) //scissors
				{
					return true;
				}
				if (y == 4) // MG-42 Machine Gun
				{
					return true;
				}
				if (y == 5) // mustard gas
				{
					return false;
				}
				if (y == 6) // IL-2 Sturmovik Aircraft
				{
					return true;
				}
				if (y == 7) // Gas Mask
				{
					return true;
				}
				if (y == 8) // AA Battery
				{
					return false;
				}
			}

			if (x == 2) //paper
			{
				if (y == 1) //rock
				{
					return true;
				}
				if (y == 3) //scissors
				{
					return false;
				}
				if (y == 4) // MG-42 Machine Gun
				{
					return false;
				}
				if (y == 5) // mustard gas
				{
					return true;
				}
				if (y == 6) // IL-2 Sturmovik Aircraft
				{
					return false;
				}
				if (y == 7) // Gas Mask
				{
					return true;
				}
				if (y == 8) // AA Battery
				{
					return false;
				}

			}

			if (x == 3) //scissors
			{
				if (y == 1) //rock
				{
					return false;
				}
				if (y == 2) //paper
				{
					return true;
				}
				if (y == 4) // MG-42 Machine Gun
				{
					return false;
				}
				if (y == 5) // mustard gas
				{
					return false;
				}
				if (y == 6) // IL-2 Sturmovik Aircraft
				{
					return false;
				}
				if (y == 7) // Gas Mask
				{
					return true;
				}
				if (y == 8) // AA Battery
				{
					return false;
				}
			}
			if (x == 4) // MG-42 Machine Gun
			{
				if (y == 1)
				{
					return false;
				}
				if (y == 2)
				{
					return true;
				}
				if (y == 3)
				{
					return true;
				}
				if (y == 5)
				{
					return false;
				}
				if (y == 6)
				{
					return false;
				}
				if (y == 7)
				{
					return true;
				}
				if (y == 8)
				{
					return true;
				}
			}
			if (x == 5)
			{
				if (y == 1)
				{
					return true;
				}
				if (y == 2)
				{
					return false;
				}
				if (y == 3)
				{
					return true;
				}
				if (y == 4)
				{
					return true;
				}
				if (y == 6)
				{
					return false;
				}
				if (y == 7)
				{
					return false;
				}
				if (y == 8)
				{
					return true;
				}
			}
			if (x == 6)
			{
				if (y == 1)
				{
					return false;
				}
				if (y == 2)
				{
					return true;
				}
				if (y == 3)
				{
					return true;
				}
				if (y == 4)
				{
					return false;
				}
				if (y == 5)
				{
					return true;
				}
				if (y == 7)
				{
					return true;
				}
				if (y == 8)
				{
					return false;
				}
			}
			if (x == 7)
			{
				if (y == 1)
				{
					return false;
				}
				if (y == 2)
				{
					return true;
				}
				if (y == 3)
				{
					return false;
				}
				if (y == 4)
				{
					return false;
				}
				if (y == 5)
				{
					return true;
				}
				if (y == 6)
				{
					return false;
				}
				if (y == 8)
				{
					return false;
				}
			}
			if (x == 8)
			{
				if (y == 1)
				{
					return false;
				}
				if (y == 2)
				{
					return true;
				}
				if (y == 3)
				{
					return true;
				}
				if (y == 4)
				{
					return true;
				}
				if (y == 5)
				{
					return false;
				}
				if (y == 6)
				{
					return false;
				}
				if (y == 7)
				{
					return true;
				}
			}
			return false;
		}
	}
}
