﻿using System;
using System.Windows.Input;

namespace pacman
{
	public class PacmanCharacter: Character
	{
		private int Timer;

		public PacmanCharacter (Board Gameboard, Player GamePlayer, Game CurrentGame)
		{
			Speed = 1;
			Direction = 0;
			State = 0;
			Board = Gameboard;
			Timer = 0;


			this.Game = CurrentGame;
			Player = GamePlayer;


			//starting position
			this.Position.X = 1;
			this.Position.Y = 1;

		}

		public override void MovementFunction()
		{
			if (State == 1) 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = 'P';
			} 
			else 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = 'p';
			}

			this.Board.DrawBoard();
			this.Game.DisplayInstructionScore();

			ConsoleKeyInfo UserInput;
			bool Moved = false;
			do
			{
				if (State == 1) 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = 'P';
				} 
				else 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = 'p';
				}

				this.Board.DrawBoard();
				this.Game.DisplayInstructionScore();
				UserInput = Console.ReadKey();
				Console.Clear ();

				if (UserInput.Key == ConsoleKey.W && this.Position.X != 0 && this.Board.Map[this.Position.X-1, this.Position.Y] != 'x' && this.Board.Map[this.Position.X-1, this.Position.Y] != '_') 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.X = this.Position.X - 1;
					Moved = true;
					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if (UserInput.Key == ConsoleKey.A && this.Position.Y != 0 && this.Board.Map[this.Position.X, this.Position.Y-1] != 'x' && this.Board.Map[this.Position.X, this.Position.Y-1] != '_') 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.Y = this.Position.Y - 1;
					Moved = true;
					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if (UserInput.Key == ConsoleKey.S && this.Position.X != 29 && this.Board.Map[this.Position.X+1, this.Position.Y] != 'x' && this.Board.Map[this.Position.X+1, this.Position.Y] != '_') 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.X = this.Position.X + 1;
					Moved = true;
					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if (UserInput.Key == ConsoleKey.D && this.Position.Y != 27 && this.Board.Map[this.Position.X, this.Position.Y +1] != 'x' && this.Board.Map[this.Position.X, this.Position.Y +1] != '_') 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.Y = this.Position.Y + 1;
					Moved = true;
					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if(UserInput.Key == ConsoleKey.A && this.Position.Y == 0)
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.Y = 27;
					Moved = true;
				}
				else if(UserInput.Key == ConsoleKey.D && this.Position.Y == 27)
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.Y = 0;
					Moved = true;
				}

			}while(Moved == false);
			//Console.WriteLine(UserInput.Key + " was pressed");
			CheckFunction ();
			Timer--;
			if (State == 1) 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = 'P';
			} 
			else 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = 'p';
			}
		}


		//used mainly for testing
		public void MovementFunction(Char Key)
		{
			if (State == 1) 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = 'P';
			} 
			else 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = 'p';
			}

			this.Board.DrawBoard();
			this.Game.DisplayInstructionScore();
			Console.Clear ();

			bool Moved = false;
			do
			{
				if (State == 1) 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = 'P';
				} 
				else 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = 'p';
				}

				this.Board.DrawBoard();
				this.Game.DisplayInstructionScore();
				Console.Clear ();

				if (Key == 'W' && this.Position.X != 0 && this.Board.Map[this.Position.X-1, this.Position.Y] != 'x' && this.Board.Map[this.Position.X-1, this.Position.Y] != '_') 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.X = this.Position.X - 1;
					Moved = true;
					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if (Key == 'A' && this.Position.Y != 0 && this.Board.Map[this.Position.X, this.Position.Y-1] != 'x' && this.Board.Map[this.Position.X, this.Position.Y-1] != '_') 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.Y = this.Position.Y - 1;
					Moved = true;
					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if (Key == 'S' && this.Position.X != 29 && this.Board.Map[this.Position.X+1, this.Position.Y] != 'x' && this.Board.Map[this.Position.X+1, this.Position.Y] != '_') 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.X = this.Position.X + 1;
					Moved = true;
					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if (Key == 'D' && this.Position.Y != 27 && this.Board.Map[this.Position.X, this.Position.Y +1] != 'x' && this.Board.Map[this.Position.X, this.Position.Y +1] != '_') 
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.Y = this.Position.Y + 1;
					Moved = true;
					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if(Key == 'A' && this.Position.Y == 0)
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.Y = 27;
					Moved = true;
				}
				else if(Key == 'D' && this.Position.Y == 27)
				{
					this.Board.Map [this.Position.X, this.Position.Y] = ' ';
					this.Position.Y = 0;
					Moved = true;
				}

			}while(Moved == false);
			//Console.WriteLine(UserInput.Key + " was pressed");
			CheckFunction ();
			Timer--;
			if (State == 1) 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = 'P';
			} 
			else 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = 'p';
			}
		}


		public override void CheckFunction()
		{
			bool ContinueGame = false;

			if (this.Board.Map [this.Position.X, this.Position.Y] == 'o') 
			{
				Player.Score++;
			}

			if (this.Board.Map [this.Position.X, this.Position.Y] == 'O') 
			{
				Player.Score++;
				Player.Score++;
				Player.Score++;

				//Can now eat ghosts
				State = 1;
				Timer = 20;
			}

			if (Timer == 0) 
			{
				State = 0;
			}


			if (this.Board.Map [this.Position.X, this.Position.Y] == 'G' && State == 0) 
			{
				Player.Lives--;
				//this.Board.Map [this.Position.X, this.Position.Y] = 'G';

				this.Position.X = 1;
				this.Position.Y = 1;
			}



			for (int x = 0; x < 30; x++) 
			{
				for(int y = 0; y < 28; y++)
				{
					if (this.Board.Map [x, y] == '0') 
					{
						ContinueGame = true;

					} 
						
				}
			}

			if(ContinueGame == false)
			{
				Console.WriteLine ("Congratulations!!! You Won!!!");
			}

			if(Player.Lives < 0)
			{
				this.Game.GameOverState = true;
			}
		}







	}
}

