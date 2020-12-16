using System;

namespace GangOfFour.Decorator.Structural
{
	/// <summary>
	/// The 'ConcreteComponent' class
	/// </summary>
	internal class ConcreteComponent : Component
	{
		public override void Operation()
		{
			Console.WriteLine("ConcreteComponent.Operation()");
		}
	}
}