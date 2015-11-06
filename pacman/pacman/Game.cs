using System;

namespace pacman
{
	public class Game
	{
		private Player GamePlayer;
		private Board GameBoard;
		private PacmanCharacter GamePacman;
		private int Lives;
		private bool GameOver;


		public Game (String name)
		{
			GamePlayer = new Player (name);
			GameBoard = new Board ();
			GamePacman = new PacmanCharacter (GameBoard);
			Lives = 3;
			GameOver = false;
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

		public PacmanCharacter Pacman
		{
			get
			{
				return GamePacman;	
			}
			set
			{
				GamePacman = value;
			}
		}

		public bool GameOverState
		{
			get
			{
				return GameOver;	
			}
		}



		public void DisplayInstructionScore()
		{
			Console.WriteLine ();
			Console.WriteLine ("Name: {0}", GamePlayer.Name);
			Console.WriteLine ("Score: {0}", GamePlayer.Score);
			Console.WriteLine ("Lives: {0}", Lives);

			Console.WriteLine ("W to move up");
			Console.WriteLine ("A to move right");
			Console.WriteLine ("S to move down");
			Console.WriteLine ("D to move up");

		}

		public void CheckFunction()
		{
			if (this.GamePacman.Board.Map [this.GamePacman.Position.X, this.GamePacman.Position.Y] == 'o') 
			{
				GamePlayer.Score++;
			}
			if (this.GamePacman.Board.Map [this.GamePacman.Position.X, this.GamePacman.Position.Y] == 'G') 
			{
				this.Lives--;
			}
			if (this.Lives == 0) 
			{
				GameOver = true;
			}
		}

	}
}

