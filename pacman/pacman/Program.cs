using System;

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

			for (int x = 0; x < 28; x++) 
			{
				TestGame.Board.Pacman.MovementFunction ();
				TestGame.Board.DrawBoard ();
				TestGame.DisplayInstructionScore ();
				//Console.Clear ();
			}


			//for

			//TestGame.Board.PopulateBoard ();


			//loop here



			//TestGame.DisplayInstructionScore ();
			//TestGame.Board.ReadMap ();

		}
	}
}
