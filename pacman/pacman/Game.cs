using System;

namespace pacman
{
	public class Game
	{
		private Player GamePlayer;
		private Board GameBoard;

		public Game (String name)
		{
			GamePlayer = new Player (name);
			GameBoard = new Board (28,30);
		}

		public Board Board
		{
			get
			{
				return GameBoard;	
			}
			set
			{
				GameBoard = value;
			}
		}

		public void DisplayInstructionScore()
		{
			Console.WriteLine ();
			Console.WriteLine ("Name: {0}", GamePlayer.Name);
			Console.WriteLine ("Score: {0}", GamePlayer.Score);

			Console.WriteLine ("W to move up");
			Console.WriteLine ("A to move right");
			Console.WriteLine ("S to move down");
			Console.WriteLine ("D to move up");

		}

	}
}

