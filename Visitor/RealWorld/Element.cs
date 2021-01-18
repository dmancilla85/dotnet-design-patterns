﻿namespace GangOfFour.Visitor.RealWorld
{
	/// <summary>
	/// The 'Element' abstract class
	/// </summary>
	internal abstract class Element

  {
    public abstract void Accept(IVisitor visitor);
  }
}
