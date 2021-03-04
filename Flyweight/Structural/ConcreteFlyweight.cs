using System;

namespace GangOfFour.Flyweight.Structural
{
	/// <summary>
	/// The 'ConcreteFlyweight' class
	/// </summary>
	internal class ConcreteFlyweight : Flyweight

	{
		public override void Operation(int extrinsicstate)
		{
			Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
		}
	}
}