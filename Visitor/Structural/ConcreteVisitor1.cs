﻿using System;

namespace GangOfFour.Visitor.Structural
{
	/// <summary>
	/// A 'ConcreteVisitor' class
	/// </summary>
	internal class ConcreteVisitor1 : Visitor

	{
		public override void VisitConcreteElementA(
			ConcreteElementA concreteElementA)
		{
			Console.WriteLine("{0} visited by {1}",
				concreteElementA.GetType().Name, this.GetType().Name);
		}

		public override void VisitConcreteElementB(
			ConcreteElementB concreteElementB)
		{
			Console.WriteLine("{0} visited by {1}",
				concreteElementB.GetType().Name, this.GetType().Name);
		}
	}
}