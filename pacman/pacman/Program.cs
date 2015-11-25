using System;
using System.Windows.Input;

namespace pacman
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Clear ();
			Console.WriteLine ("Enter User Name: ");
			string UserName;
			UserName = Console.ReadLine();
			Game MainGame = new Game (UserName);
			MainGame.Board.ReadMap ();

			MainGame.Board.DrawBoard ();
			MainGame.DisplayInstructionScore ();

			do
			{
				MainGame.Pacman.MovementFunction ();
				MainGame.RandomGhost.MovementFunction();
				MainGame.TrackingGhost.TrackMovementFunction();
				MainGame.Board.DrawBoard ();
				MainGame.DisplayInstructionScore ();
			}while(MainGame.GameOverState == false);

			Console.WriteLine ("Game Over");
				

		}
	}
}
