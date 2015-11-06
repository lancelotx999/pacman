using System;
using System.Windows.Input;

namespace pacman
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");

			//Board testboard = new Board (10, 10);

			//testboard.PopulateBoard ();
			//testboard.DrawBoard ();

			Game TestGame = new Game ("TESTGAME");
			TestGame.Board.ReadMap ();

			TestGame.Board.DrawBoard ();
			TestGame.DisplayInstructionScore ();

			/*for (int x = 0; x < 28; x++) 
			{
				TestGame.Pacman.MovementFunction ();
				TestGame.Board.DrawBoard ();
				TestGame.DisplayInstructionScore ();
				//Console.Clear ();
			}*/

			do
			{
				TestGame.Pacman.MovementFunction ();
				TestGame.CheckFunction();
				TestGame.Board.DrawBoard ();
				TestGame.DisplayInstructionScore ();
			}while(TestGame.GameOverState == false);


			//TestGame.Board.DebugBoard ();
			//TestGame.Board.DrawBoard ();


			//for

			//TestGame.Board.PopulateBoard ();


			//loop here



			//TestGame.DisplayInstructionScore ();
			//TestGame.Board.ReadMap ();

		}
	}
}
