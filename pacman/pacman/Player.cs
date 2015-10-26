using System;

namespace pacman
{
	public class Player
	{
		private string UserName;
		private int UserScore;

		public Player (string name)
		{
			UserName = name;
			UserScore = 0;

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
	}
}

