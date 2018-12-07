using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPSEngine;

namespace RPS_Game
{
	class Program
	{
		static void Main(string[] args)
		{
			RPSGame rpsGame = new RPSGame();
			Random rnd = new Random();
			while (true)
			{
				Console.WriteLine();

				int userRPS = RPSGame.ReadRPS();
				Console.Write("You guessed: ");
				rpsGame.WriteRPS(userRPS);
				Console.WriteLine();

				int computerRPS = rnd.Next(8) + 1; //Next return 0-2
				Console.Write("I guessed: ");
				RPSGame.WriteRPS(computerRPS);
				Console.WriteLine();

				if (userRPS == computerRPS)
				{
					Console.WriteLine("It's a draw!");
					continue;
				}

				bool gameResult = rpsGame.CompareRPS(userRPS, computerRPS);
				if (gameResult)
				{
					Console.WriteLine("You win! I lose!");
				}
				else
				{
					Console.WriteLine("I win! You lose!");
				}
			}
		}
	}
}
