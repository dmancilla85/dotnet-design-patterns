﻿using System;

namespace GangOfFour.Flyweight.RealWorld
{
	/// <summary>
	/// A 'ConcreteFlyweight' class
	/// </summary>
	internal class CharacterA : Character

	{
		// Constructor
		public CharacterA()
		{
			this.symbol = 'A';
			this.height = 100;
			this.width = 120;
			this.ascent = 70;
			this.descent = 0;
		}

		public override void Display(int pointSize)
		{
			this.pointSize = pointSize;
			Console.WriteLine(this.symbol +
				" (pointsize " + this.pointSize + ")");
		}
	}
}