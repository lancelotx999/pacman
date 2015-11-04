using System;

namespace pacman
{
	public class Position
	{
		private int x,y;

		public Position ()
		{
			x = 0;
			y = 0;
		}

		public int X
		{
			get
			{
				return x;	
			}
			set
			{
				x = value;
			}
		}

		public int Y
		{
			get
			{
				return y;	
			}
			set
			{
				y = value;
			}
		}
	}
}

