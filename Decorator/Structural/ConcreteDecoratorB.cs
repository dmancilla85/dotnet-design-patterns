using System;

namespace GangOfFour.Decorator.Structural
{
	/// <summary>
	/// The 'ConcreteDecoratorB' class
	/// </summary>
	internal class ConcreteDecoratorB : Decorator

	{
		private void AddedBehavior()
		{
		}

		public override void Operation()
		{
			base.Operation();
			AddedBehavior();
			Console.WriteLine("ConcreteDecoratorB.Operation()");
		}
	}
}