using System;

namespace GangOfFour.Flyweight.Structural
{
	/// <summary>
	/// The 'UnsharedConcreteFlyweight' class
	/// </summary>
	internal class UnsharedConcreteFlyweight : Flyweight

  {
    public override void Operation(int extrinsicstate)
    {
      Console.WriteLine("UnsharedConcreteFlyweight: " +
        extrinsicstate);
    }
  }
}
