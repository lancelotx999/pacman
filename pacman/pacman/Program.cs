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

			//for

			//TestGame.Board.PopulateBoard ();
			TestGame.Board.ReadMap ();
			TestGame.Board.DrawBoard ();
			TestGame.DisplayInstructionScore ();
			//TestGame.Board.ReadMap ();

		}
	}
}
