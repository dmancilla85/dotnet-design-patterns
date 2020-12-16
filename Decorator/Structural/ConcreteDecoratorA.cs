using System;

namespace GangOfFour.Decorator.Structural
{
	/// <summary>
	/// The 'ConcreteDecoratorA' class
	/// </summary>
	internal class ConcreteDecoratorA : Decorator

	{
		public override void Operation()
		{
			base.Operation();
			Console.WriteLine("ConcreteDecoratorA.Operation()");
		}
	}
}