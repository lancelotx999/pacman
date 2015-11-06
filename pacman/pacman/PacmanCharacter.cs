using System;
using System.Windows.Input;

namespace pacman
{
	public class PacmanCharacter: Character
	{
		public PacmanCharacter (Board Gameboard)
		{
			Speed = 1;
			Direction = 0;
			State = 0;
			Board = Gameboard;


			//randomise later
			this.Position.X = 1;
			this.Position.Y = 1;

		}

		public override void MovementFunction()
		{
			this.Board.Map [this.Position.X, this.Position.Y] = 'p';

			ConsoleKeyInfo UserInput;

			UserInput = Console.ReadKey();
			Console.Clear ();

			if (UserInput.Key == ConsoleKey.W && this.Position.X != 1 && this.Board.Map[this.Position.X-1, this.Position.Y] != 'x' && this.Board.Map[this.Position.X-1, this.Position.Y] != '_') 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = ' ';
				this.Position.X = this.Position.X - 1;
				//Console.WriteLine ("X = " + this.Position.X);
				//Console.WriteLine ("Y = " + this.Position.Y);
			}
			else if (UserInput.Key == ConsoleKey.A && this.Position.Y != 1 && this.Board.Map[this.Position.X, this.Position.Y-1] != 'x' && this.Board.Map[this.Position.X, this.Position.Y-1] != '_') 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = ' ';
				this.Position.Y = this.Position.Y - 1;
				//Console.WriteLine ("X = " + this.Position.X);
				//Console.WriteLine ("Y = " + this.Position.Y);
			}
			else if (UserInput.Key == ConsoleKey.S && this.Position.X != 29 && this.Board.Map[this.Position.X+1, this.Position.Y] != 'x' && this.Board.Map[this.Position.X+1, this.Position.Y] != '_') 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = ' ';
				this.Position.X = this.Position.X + 1;
				//Console.WriteLine ("X = " + this.Position.X);
				//Console.WriteLine ("Y = " + this.Position.Y);
			}
			else if (UserInput.Key == ConsoleKey.D && this.Position.Y != 29 && this.Board.Map[this.Position.X, this.Position.Y +1] != 'x' && this.Board.Map[this.Position.X, this.Position.Y +1] != '_') 
			{
				this.Board.Map [this.Position.X, this.Position.Y] = ' ';
				this.Position.Y = this.Position.Y + 1;
				//Console.WriteLine ("X = " + this.Position.X);
				//Console.WriteLine ("Y = " + this.Position.Y);
			}
			//Console.WriteLine(UserInput.Key + " was pressed");

			this.Board.Map [this.Position.X, this.Position.Y] = 'p';
		}





	}
}

