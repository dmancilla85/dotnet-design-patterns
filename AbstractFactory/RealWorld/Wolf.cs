using System;

namespace GangOfFour.AbstractFactory.RealWorld
{
	/// <summary>
	/// The 'ProductB2' class
	/// </summary>
	internal class Wolf : Carnivore

	{
		public override void Eat(Herbivore h)
		{
			// Eat Bison
			Console.WriteLine(this.GetType().Name +
				" eats " + h.GetType().Name);
		}
	}
}