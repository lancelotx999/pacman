using System;
using NUnit.Framework;

namespace pacman
{
	[TestFixture()]
	public class TestCases
	{
		public TestCases ()
		{
		}

		[Test()]
		public void TestPacman()
		{
			string UserName;
			UserName = "TestGame";
			Game TestGame = new Game (UserName);
			TestGame.Board.ReadMap ();

			TestGame.Board.DrawBoard ();
			TestGame.DisplayInstructionScore ();

			Assert.IsTrue (TestGame.Pacman.Position.X == 1);
			Assert.IsTrue (TestGame.Pacman.Position.Y == 1);
			Assert.IsTrue (TestGame.Pacman.State == 0);
			Assert.IsTrue (TestGame.Player.Score == 0);

			TestGame.Pacman.MovementFunction ('S');

			Assert.IsTrue (TestGame.Pacman.Position.X == 2);
			Assert.IsTrue (TestGame.Pacman.Position.Y == 1);
			Assert.IsTrue (TestGame.Player.Score == 3);
			Assert.IsTrue (TestGame.Pacman.State == 1);

			TestGame.Pacman.MovementFunction ('W');

			Assert.IsTrue (TestGame.Pacman.Position.X == 1);
			Assert.IsTrue (TestGame.Pacman.Position.Y == 1);

			TestGame.Pacman.MovementFunction ('D');

			Assert.IsTrue (TestGame.Pacman.Position.X == 1);
			Assert.IsTrue (TestGame.Pacman.Position.Y == 2);
			Assert.IsTrue (TestGame.Player.Score == 4);

			TestGame.Pacman.MovementFunction ('A');

			Assert.IsTrue (TestGame.Pacman.Position.X == 1);
			Assert.IsTrue (TestGame.Pacman.Position.Y == 1);
		}

		[Test()]
		public void TestPlayer()
		{
			string UserName;
			UserName = "TestGame";
			Game TestGame = new Game (UserName);
			TestGame.Board.ReadMap ();

			TestGame.Board.DrawBoard ();
			TestGame.DisplayInstructionScore ();

			TestGame.RandomGhost.Position.X = 1;
			TestGame.RandomGhost.Position.Y = 1;

			Assert.IsTrue (TestGame.Player.Lives == 3);

			TestGame.Pacman.CheckFunction ();
			TestGame.RandomGhost.CheckFunction ();
			Assert.IsTrue (TestGame.Player.Lives == 2);



		}
	}
}

