﻿using System;

namespace GangOfFour.Strategy.Structural
{
	/// <summary>
	/// A 'ConcreteStrategy' class
	/// </summary>
	internal class ConcreteStrategyB : Strategy

	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine(
				"Called ConcreteStrategyB.AlgorithmInterface()");
		}
	}
}