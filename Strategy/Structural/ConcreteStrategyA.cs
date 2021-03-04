using System;

namespace GangOfFour.Strategy.Structural
{
	/// <summary>
	/// A 'ConcreteStrategy' class
	/// </summary>
	internal class ConcreteStrategyA : Strategy

	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine(
				"Called ConcreteStrategyA.AlgorithmInterface()");
		}
	}
}