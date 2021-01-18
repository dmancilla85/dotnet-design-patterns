using System;

namespace GangOfFour.Strategy.Structural
{
	/// <summary>
	/// A 'ConcreteStrategy' class
	/// </summary>
	internal class ConcreteStrategyC : Strategy

  {
    public override void AlgorithmInterface()
    {
      Console.WriteLine(
        "Called ConcreteStrategyC.AlgorithmInterface()");
    }
  }
}
