﻿namespace GangOfFour.Flyweight.RealWorld
{
	/// <summary>
	/// The 'Flyweight' abstract class
	/// </summary>
	internal abstract class Character

  {
    protected char symbol;
    protected int width;
    protected int height;
    protected int ascent;
    protected int descent;
    protected int pointSize;

    public abstract void Display(int pointSize);
  }
}
