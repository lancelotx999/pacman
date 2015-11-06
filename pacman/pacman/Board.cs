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


		public Board ()
		{
			GameBoard = new char[31,28];
			//RandomGenerator = new Random ();
			Position = new Position ();
			GamePacman = new PacmanCharacter ();

			this.xSize = 31;
			this.ySize = 28;
		}


		public void DrawBoard()
		{
			GameBoard [GamePacman.Position.X, GamePacman.Position.Y] = 'p';

			for(Position.X = 0; Position.X < xSize; Position.X++)
			{
				for(Position.Y = 0; Position.Y < ySize; Position.Y++)
				{
					Console.Write (GameBoard [Position.X,Position.Y]);
				}
				//Console.WriteLine("\n");
			}

			Console.WriteLine("\n");
		}

		/*public void DrawBoard()
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


		}*/

		public void DebugBoard()
		{
			GameBoard [GamePacman.Position.X, GamePacman.Position.Y] = 'p';
			int row = 0;
			int col = 0;

			for(Position.X = 0; Position.X != xSize; Position.X++)
			{
				for(Position.Y = 0; Position.Y != ySize; Position.Y++)
				{
					Console.WriteLine ("COL: {0}", col);
					col++;
				}
				//Console.WriteLine("\n");
				Console.WriteLine("ROW: {0}", row);
				row++;
				col = 0;
			}

			Console.WriteLine (GameBoard[xSize-1, ySize-1]);
			Console.WriteLine (GameBoard[xSize-1, ySize-1]);
			Console.WriteLine (GameBoard[xSize-1, ySize-1]);

		}

		public void ReadMap()
		{
			char ch;

			StreamReader reader;
			reader = new StreamReader(@"./PacmanMaps/Map1.txt");

			/*for(Position.X = 0; Position.X != xSize; Position.X++)
			{
				string g = (String)reader.ReadLine();
				for(Position.Y = 0; Position.Y != ySize; Position.Y++)
				{
					//ch = (char)reader.ReadLine();
					ch = g[Position.Y];
					GameBoard[Position.X,Position.Y] = ch;
				}
			}*/

			while (!reader.EndOfStream) 
			{
				ch = (char)reader.Read();
				GameBoard[Position.X,Position.Y] = reader.ReadLine ().ToCharArray();
				Console.WriteLine (reader.ReadLine ());
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

