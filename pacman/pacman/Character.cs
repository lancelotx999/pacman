﻿using System;

namespace pacman
{
	public abstract class Character
	{
		private Position CharPosition = new Position();
		private int CharState;
		private int CharSpeed;
		private int CharDirection;
		public Character ()
		{
			
		}

		public Position Position
		{
			get
			{
				return CharPosition;	
			}
			set
			{
				CharPosition = value;
			}
		}

		public int Speed
		{
			get
			{
				return CharSpeed;	
			}
			set
			{
				CharSpeed = value;
			}
		}

		public int State
		{
			get
			{
				return CharState;	
			}
			set
			{
				CharState = value;
			}
		}

		public int Direction
		{
			get
			{
				return CharDirection;	
			}
			set
			{
				CharDirection = value;
			}
		}

		abstract public void MovementFunction();
	}
}

