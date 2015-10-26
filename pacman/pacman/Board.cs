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

		private static Random RandomGenerator;


		public Board (int xSize, int ySize)
		{
			GameBoard = new char[xSize,ySize];
			RandomGenerator = new Random ();
			Position = new Position ();

			this.xSize = xSize;
			this.ySize = ySize;

			for(Position.X = 0; Position.X != xSize; Position.X++)
			{
				for(Position.Y = 0; Position.Y != ySize; Position.Y++)
				{
					if (RandomGenerator.NextDouble () < 0.25) 
					{
						GameBoard[Position.X,Position.Y] = 'X';

					}
					else
					{
						GameBoard[Position.X,Position.Y] = ' ';
					}
				}
			}
		}


		public void DrawBoard()
		{
			for(Position.X = 0; Position.X != xSize; Position.X++)
			{
				for(Position.Y = 0; Position.Y != ySize; Position.Y++)
				{
					Console.Write (GameBoard [Position.X,Position.Y]);
				}
				//Console.WriteLine("\n");
			}
		}

		public void PopulateBoard()
		{
			for(Position.X = 0; Position.X != xSize; Position.X++)
			{
				for(Position.Y = 0; Position.Y != ySize; Position.Y++)
				{
					if (RandomGenerator.NextDouble () < 0.1 && GameBoard[Position.X,Position.Y] != 'X') 
					{
						GameBoard[Position.X,Position.Y] = 'O';

					}
					else if (GameBoard[Position.X,Position.Y] == ' ')
					{
						GameBoard[Position.X,Position.Y] = 'o';
					}
				}
			}
		}

		public void ReadMap()
		{
			char ch;

			StreamReader reader;
			reader = new StreamReader(@"./PacmanMaps/Map1.txt");

			//do
			//{
			//	ch = (char)reader.Read();
				
			//	Console.Write(ch);
			//	
				//for(Position.X = 0; Position.X != xSize; Position.X++)
			//	{
					//for(Position.Y = 0; Position.Y != ySize; Position.Y++)
			//		{
			//				GameBoard[Position.X,Position.Y] = ch;
			//		}
			//	}

			//	//Tchar++;
			//} while (!reader.EndOfStream);

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



	}
}

