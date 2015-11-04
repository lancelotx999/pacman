using System;
using System.Windows.Input;

namespace pacman
{
	public class PacmanCharacter: Character
	{
		public PacmanCharacter ()
		{
			Speed = 1;
			Direction = 0;
			State = 0;

			//randomise later
			this.Position.X = 0;
			this.Position.Y = 0;

		}

		public override void MovementFunction()
		{
			ConsoleKeyInfo UserInput;

			UserInput = Console.ReadKey();
			Console.Clear ();

			Console.WriteLine ("X = " + this.Position.X);
			Console.WriteLine ("Y = " + this.Position.Y);
			if (UserInput.Key == ConsoleKey.W) 
			{
				this.Position.X = this.Position.X - 1;
				Console.WriteLine ("X = " + this.Position.X);
				Console.WriteLine ("Y = " + this.Position.Y);
			}
			else if (UserInput.Key == ConsoleKey.A) 
			{
				this.Position.Y = this.Position.Y - 1;
				Console.WriteLine ("X = " + this.Position.X);
				Console.WriteLine ("Y = " + this.Position.Y);
			}
			else if (UserInput.Key == ConsoleKey.S) 
			{
				this.Position.X = this.Position.X + 1;
				Console.WriteLine ("X = " + this.Position.X);
				Console.WriteLine ("Y = " + this.Position.Y);
			}
			else if (UserInput.Key == ConsoleKey.D) 
			{
				this.Position.Y = this.Position.Y + 1;
				Console.WriteLine ("X = " + this.Position.X);
				Console.WriteLine ("Y = " + this.Position.Y);
			}
			Console.WriteLine(UserInput.Key + " was pressed");
		}

	}
}

