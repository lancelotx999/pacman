using System;

namespace pacman
{
	public class Player
	{
		private string UserName;
		private int UserScore;
		private int UserLives;

		public Player (string name)
		{
			UserName = name;
			UserScore = 0;
			UserLives = 3;

		}

		public string Name
		{
			get
			{
				return UserName;	
			}
			set
			{
				UserName = value;
			}
		}

		public int Score
		{
			get
			{
				return UserScore;	
			}
			set
			{
				UserScore = value;
			}
		}

		public int Lives
		{
			get
			{
				return UserLives;	
			}
			set
			{
				UserLives = value;
			}
		}
	}
}

