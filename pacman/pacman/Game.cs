﻿using System;

namespace pacman
{
	public class Game
	{
		private Player GamePlayer;
		private Board GameBoard;
		private PacmanCharacter GamePacman;
		private GhostCharacter GameRandomGhost;
		private GhostCharacter GameTrackingGhost;

		private bool GameOver;


		public Game (String name)
		{
			GamePlayer = new Player (name);
			GameBoard = new Board ();
			GamePacman = new PacmanCharacter (GameBoard, GamePlayer, this);
			GameRandomGhost = new GhostCharacter (GameBoard, GamePlayer,this,GamePacman);
			GameTrackingGhost = new GhostCharacter (GameBoard, GamePlayer,this,GamePacman);
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

		public Player Player
		{
			get
			{
				return GamePlayer;	
			}
			set
			{
				GamePlayer = value;
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

		public GhostCharacter RandomGhost
		{
			get
			{
				return GameRandomGhost;	
			}
			set
			{
				GameRandomGhost = value;
			}
		}

		public GhostCharacter TrackingGhost
		{
			get
			{
				return GameTrackingGhost;	
			}
			set
			{
				GameTrackingGhost = value;
			}
		}

		public bool GameOverState
		{
			get
			{
				return GameOver;	
			}
			set 
			{
				GameOver = value;
			}
		}



		public void DisplayInstructionScore()
		{
			Console.WriteLine ();
			Console.WriteLine ("Name: {0}", GamePlayer.Name);
			Console.WriteLine ("Score: {0}", GamePlayer.Score);
			Console.WriteLine ("Lives: {0}", GamePlayer.Lives);
			Console.WriteLine ("State: {0}", GamePacman.State);

			Console.WriteLine ("W to move up");
			Console.WriteLine ("A to move right");
			Console.WriteLine ("S to move down");
			Console.WriteLine ("D to move up");

		}
			

	}
}

