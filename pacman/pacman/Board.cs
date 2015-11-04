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

		private PacmanCharacter GamePacman;


		public Board (int xSize, int ySize)
		{
			GameBoard = new char[xSize,ySize];
			//RandomGenerator = new Random ();
			Position = new Position ();
			GamePacman = new PacmanCharacter ();

			this.xSize = xSize;
			this.ySize = ySize;
		}


		public void DrawBoard()
		{
			GameBoard [GamePacman.Position.X, GamePacman.Position.Y] = 'p';
			for(Position.X = 0; Position.X != xSize; Position.X++)
			{
				for(Position.Y = 0; Position.Y != ySize; Position.Y++)
				{
					Console.Write (GameBoard [Position.X,Position.Y]);
				}
				//Console.WriteLine("\n");
			}
		}

		public void ReadMap()
		{
			char ch;

			StreamReader reader;
			reader = new StreamReader(@"./PacmanMaps/Map1.txt");

			for(Position.X = 0; Position.X != xSize; Position.X++)
			{
				for(Position.Y = 0; Position.Y != ySize; Position.Y++)
				{
					ch = (char)reader.Read();
					GameBoard[Position.X,Position.Y] = ch;
				}
			}
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

		private char[,] Map 
		{
			get 
			{
				return GameBoard;
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



	}
}

