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
			Game TestGame = new Game (UserName);
			TestGame.Board.ReadMap ();

			TestGame.Board.DrawBoard ();
			TestGame.DisplayInstructionScore ();

			do
			{
				TestGame.Pacman.MovementFunction ();
				TestGame.RandomGhost.MovementFunction();
				TestGame.TrackingGhost.TrackMovementFunction();
				//TestGame.CheckFunction();
				TestGame.Board.DrawBoard ();
				TestGame.DisplayInstructionScore ();
			}while(TestGame.GameOverState == false);

			Console.WriteLine ("Game Over");
				

		}
	}
}
