using System;
using System.Windows.Input;

namespace pacman
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Game TestGame = new Game ("TESTGAME");
			TestGame.Board.ReadMap ();

			TestGame.Board.DrawBoard ();
			TestGame.DisplayInstructionScore ();

			do
			{
				TestGame.Pacman.MovementFunction ();
				//TestGame.CheckFunction();
				TestGame.Board.DrawBoard ();
				TestGame.DisplayInstructionScore ();
			}while(TestGame.GameOverState == false);

			Console.WriteLine ("Game Over");
				

		}
	}
}
