using System;
using System.Linq;
using System.Text;
using System.IO;

namespace pacman
{
	public class Board
	{
		private char[,] GameBoard; 

		private int xSize, ySize;

		private Position Position;

		//private static Random RandomGenerator;

		//private PacmanCharacter GamePacman;


		public Board ()
		{
			// x == 30 y == 28
			int x = 30;
			int y = 28;
			GameBoard = new char[x,y];
			//RandomGenerator = new Random ();
			Position = new Position ();
			//GamePacman = new PacmanCharacter ();

			this.xSize = x;
			this.ySize = y;
		}


		public void DrawBoard()
		{
			//GameBoard [GamePacman.Position.X, GamePacman.Position.Y] = 'p';

			for(Position.X = 0; Position.X < xSize; Position.X++)
			{
				for(Position.Y = 0; Position.Y < ySize; Position.Y++)
				{
					Console.Write (GameBoard [Position.X,Position.Y]);
				}
				Console.WriteLine ();
			}
		}

		public void ReadMap()
		{
			char[] ch = new char[28];
			string BoardLine;

			StreamReader reader = new StreamReader(@"./PacmanMaps/Map1.txt");

			for(Position.X = 0; Position.X < xSize; Position.X++)
			{
				BoardLine = reader.ReadLine();
				ch = BoardLine.ToCharArray();

				for(Position.Y = 0; Position.Y < ySize; Position.Y++)
				{
					GameBoard [Position.X, Position.Y] = ch [Position.Y];
				}
			}

			//GamePacman = new PacmanCharacter (GameBoard);
		}

		public Position Pos
		{
			get
			{
				return Position;	
			}
			set
			{
				Position = value;
			}
		}

		public char[,] Map 
		{
			get 
			{
				return GameBoard;
			}
			set 
			{
				value = GameBoard;
			}
		}





	}
}

