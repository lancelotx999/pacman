using System;

namespace pacman
{
	public class GhostCharacter: Character
	{
		private static Random RandomGenerator;
		private char OverlapCharacter = ' ';
		private PacmanCharacter PlayerPacman;

		public GhostCharacter (Board Gameboard, Player GamePlayer, Game CurrentGame, PacmanCharacter Pacman)
		{
			Speed = 1;
			Direction = 0;
			State = 0;
			Board = Gameboard;

			this.Game = CurrentGame;
			Player = GamePlayer;
			PlayerPacman = Pacman;


			//starting position
			this.Position.X = 13;
			this.Position.Y = 14;

		}


		//random movement
		public override void MovementFunction()
		{
			CheckFunction ();

			this.Board.Map [this.Position.X, this.Position.Y] = 'G';
			this.Board.DrawBoard();
			this.Game.DisplayInstructionScore();

			bool Moved = false;

			do 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = 'G';
				this.Board.DrawBoard();
				this.Game.DisplayInstructionScore();
				RandomGenerator = new Random ();

				if (RandomGenerator.NextDouble() <= 0.25 && this.Position.X != 0 && this.Board.Map[this.Position.X-1, this.Position.Y] != 'x' && this.Board.Map[this.Position.X-1, this.Position.Y] != '_'&& this.Board.Map[this.Position.X-1, this.Position.Y] != 'G') 
				{
					if(this.Board.Map [this.Position.X-1, this.Position.Y] == 'p')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';
						this.Position.X = this.Position.X - 1;

						Player.Lives--;
						PlayerPacman.Position.X = 1;
						PlayerPacman.Position.Y = 1;

						Moved = true;
					}
					else if(this.Board.Map [this.Position.X-1, this.Position.Y] == 'P')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';

						this.Position.X = 13;
						this.Position.Y = 14;

						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;

						Moved = true;
					}
					else
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = this.Board.Map [this.Position.X-1, this.Position.Y];
						this.Position.X = this.Position.X - 1;
						Moved = true;
					}


					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if (RandomGenerator.NextDouble() > 0.25 && RandomGenerator.NextDouble() <= 0.50 && this.Position.Y != 0 && this.Board.Map[this.Position.X, this.Position.Y-1] != 'x' && this.Board.Map[this.Position.X, this.Position.Y-1] != '_'&& this.Board.Map[this.Position.X, this.Position.Y-1] != 'G') 
				{
					if(this.Board.Map [this.Position.X, this.Position.Y-1] == 'p')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';
						this.Position.Y = this.Position.Y - 1;

						Player.Lives--;
						PlayerPacman.Position.X = 1;
						PlayerPacman.Position.Y = 1;

						Moved = true;
					}
					else if(this.Board.Map [this.Position.X, this.Position.Y-1] == 'P')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';

						this.Position.X = 13;
						this.Position.Y = 14;

						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;

						Moved = true;
					}
					else
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = this.Board.Map [this.Position.X, this.Position.Y-1];
						this.Position.Y = this.Position.Y - 1;
						Moved = true;
					}

					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if (RandomGenerator.NextDouble() > 0.50 && RandomGenerator.NextDouble() <= 0.75 && this.Position.X != 29 && this.Board.Map[this.Position.X+1, this.Position.Y] != 'x' && this.Board.Map[this.Position.X+1, this.Position.Y] != '_'&& this.Board.Map[this.Position.X+1, this.Position.Y] != 'G') 
				{
					if(this.Board.Map [this.Position.X+1, this.Position.Y] == 'p')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';
						this.Position.X = this.Position.X + 1;

						Player.Lives--;
						PlayerPacman.Position.X = 1;
						PlayerPacman.Position.Y = 1;

						Moved = true;
					}
					else if(this.Board.Map [this.Position.X+1, this.Position.Y] == 'P')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';

						this.Position.X = 13;
						this.Position.Y = 14;

						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;

						Moved = true;
					}
					else
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = this.Board.Map [this.Position.X+1, this.Position.Y];
						this.Position.X = this.Position.X + 1;
						Moved = true;
					}

					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if (RandomGenerator.NextDouble() > 0.75 && RandomGenerator.NextDouble() <= 1 && this.Position.Y != 27 && this.Board.Map[this.Position.X, this.Position.Y +1] != 'x' && this.Board.Map[this.Position.X, this.Position.Y +1] != '_'&& this.Board.Map[this.Position.X, this.Position.Y +1] != 'G') 
				{
					if(this.Board.Map [this.Position.X, this.Position.Y+1] == 'p')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';
						this.Position.Y = this.Position.Y + 1;

						Player.Lives--;
						PlayerPacman.Position.X = 1;
						PlayerPacman.Position.Y = 1;

						Moved = true;
					}
					else if(this.Board.Map [this.Position.X, this.Position.Y+1] == 'P')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';

						this.Position.X = 13;
						this.Position.Y = 14;

						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;

						Moved = true;
					}
					else
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = this.Board.Map [this.Position.X, this.Position.Y+1];
						this.Position.Y = this.Position.Y + 1;
						Moved = true;
					}

					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if(RandomGenerator.NextDouble() > 0.25 && RandomGenerator.NextDouble() <= 0.50 && this.Position.Y == 0 && this.Board.Map[this.Position.X, 27] != 'G')
				{
					if(this.Board.Map [this.Position.X, 27] == 'p')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';
						this.Position.Y = 27;

						Player.Lives--;
						PlayerPacman.Position.X = 1;
						PlayerPacman.Position.Y = 1;

						Moved = true;
					}
					else if(this.Board.Map [this.Position.X, 27] == 'P')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';

						this.Position.X = 13;
						this.Position.Y = 14;

						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;

						Moved = true;
					}
					else
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = this.Board.Map [this.Position.X, this.Position.Y+1];
						this.Position.Y = 27;
						Moved = true;
					}


				}
				else if(RandomGenerator.NextDouble() > 0.75 && RandomGenerator.NextDouble() <= 1 && this.Position.Y == 27 && this.Position.Y == 0 && this.Board.Map[this.Position.X, 0] != 'G')
				{
					if(this.Board.Map [this.Position.X, 27] == 'p')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';
						this.Position.Y = 0;

						Player.Lives--;
						PlayerPacman.Position.X = 1;
						PlayerPacman.Position.Y = 1;

						Moved = true;
					}
					else if(this.Board.Map [this.Position.X, 0] == 'P')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';

						this.Position.X = 13;
						this.Position.Y = 14;

						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;

						Moved = true;
					}
					else
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = this.Board.Map [this.Position.X, this.Position.Y+1];
						this.Position.Y = 0;
						Moved = true;
					}
				}

			} while(Moved == false);


			//Console.WriteLine(UserInput.Key + " was pressed");
			CheckFunction ();
			this.Board.Map [this.Position.X, this.Position.Y] = 'G';
		}

		public void TrackMovementFunction()
		{
			CheckFunction ();
			this.Board.Map [this.Position.X, this.Position.Y] = 'G';

			bool Moved = false;

			int VerticalDifference = this.Position.X - PlayerPacman.Position.X;
			int HorizontalDifference = this.Position.Y - PlayerPacman.Position.Y;

			do 
			{
				if (VerticalDifference > 0 && this.Position.X != 0 && this.Board.Map[this.Position.X-1, this.Position.Y] != 'x' && this.Board.Map[this.Position.X, this.Position.Y +1] != '_' && this.Board.Map[this.Position.X, this.Position.Y +1] != 'G') 
				{
					if(this.Board.Map [this.Position.X-1, this.Position.Y] == 'p')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';
						this.Position.X = this.Position.X - 1;

						Player.Lives--;
						PlayerPacman.Position.X = 1;
						PlayerPacman.Position.Y = 1;

						Moved = true;
					}
					else if(this.Board.Map [this.Position.X-1, this.Position.Y] == 'P')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';

						this.Position.X = 13;
						this.Position.Y = 14;

						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;

						Moved = true;
					}
					else
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = this.Board.Map [this.Position.X-1, this.Position.Y];
						this.Position.X = this.Position.X - 1;
						Moved = true;
					}
					//Console.WriteLine ("X = " + this.Position.X);
					//Console.WriteLine ("Y = " + this.Position.Y);
				}
				else if (HorizontalDifference > 0 && this.Position.Y != 0 && this.Board.Map[this.Position.X, this.Position.Y-1] != 'x' && this.Board.Map[this.Position.X, this.Position.Y-1] != '_' && this.Board.Map[this.Position.X, this.Position.Y-1] != 'G') 
				{
					if(this.Board.Map [this.Position.X, this.Position.Y-1] == 'p')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';
						this.Position.Y = this.Position.Y - 1;

						Player.Lives--;
						PlayerPacman.Position.X = 1;
						PlayerPacman.Position.Y = 1;

						Moved = true;
					}
					else if(this.Board.Map [this.Position.X, this.Position.Y-1] == 'P')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';

						this.Position.X = 13;
						this.Position.Y = 14;

						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;

						Moved = true;
					}
					else
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = this.Board.Map [this.Position.X, this.Position.Y-1];
						this.Position.Y = this.Position.Y - 1;
						Moved = true;
					}
				}
				else if (VerticalDifference < 0 && this.Position.X != 29 && this.Board.Map[this.Position.X+1, this.Position.Y] != 'x' && this.Board.Map[this.Position.X+1, this.Position.Y] != '_'&& this.Board.Map[this.Position.X+1, this.Position.Y] != 'G') 
				{
					if(this.Board.Map [this.Position.X+1, this.Position.Y] == 'p')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';
						this.Position.X = this.Position.X + 1;

						Player.Lives--;
						PlayerPacman.Position.X = 1;
						PlayerPacman.Position.Y = 1;

						Moved = true;
					}
					else if(this.Board.Map [this.Position.X+1, this.Position.Y] == 'P')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';

						this.Position.X = 13;
						this.Position.Y = 14;

						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;

						Moved = true;
					}
					else
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = this.Board.Map [this.Position.X+1, this.Position.Y];
						this.Position.X = this.Position.X + 1;
						Moved = true;
					}
				}
				else if (HorizontalDifference < 0 && this.Position.Y != 27 && this.Board.Map[this.Position.X, this.Position.Y +1] != 'x' && this.Board.Map[this.Position.X, this.Position.Y +1] != '_'&& this.Board.Map[this.Position.X, this.Position.Y +1] != 'G') 
				{
					if(this.Board.Map [this.Position.X, this.Position.Y+1] == 'p')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';
						this.Position.Y = this.Position.Y + 1;

						Player.Lives--;
						PlayerPacman.Position.X = 1;
						PlayerPacman.Position.Y = 1;

						Moved = true;
					}
					else if(this.Board.Map [this.Position.X, this.Position.Y+1] == 'P')
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = ' ';

						this.Position.X = 11;
						this.Position.Y = 14;

						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;
						this.Player.Score++;

						Moved = true;
					}
					else
					{
						this.Board.Map [this.Position.X, this.Position.Y] = OverlapCharacter;
						OverlapCharacter = this.Board.Map [this.Position.X, this.Position.Y+1];
						this.Position.Y = this.Position.Y + 1;
						Moved = true;
					}
				}
				else
				{
					MovementFunction();
				}

			} while(Moved == false);


			//Console.WriteLine(UserInput.Key + " was pressed");
			CheckFunction ();
			this.Board.Map [this.Position.X, this.Position.Y] = 'G';
		}


		public override void CheckFunction()
		{
			//bool ContinueGame = false;

			if (this.Board.Map [this.Position.X, this.Position.Y] == 'P' ) 
			{
				//ghost died
				OverlapCharacter = ' ';
				this.Position.X = 13;
				this.Position.Y = 14;

				this.Player.Score++;
				this.Player.Score++;
				this.Player.Score++;
				this.Player.Score++;
				this.Player.Score++;

			}

		}
	}
}

