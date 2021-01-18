using System;

namespace GangOfFour.AbstractFactory.RealWorld
{
	/// <summary>
	/// The 'ProductB1' class
	/// </summary>
	internal class Lion : Carnivore

	{
		public override void Eat(Herbivore h)
		{
			// Eat Wildebeest
			Console.WriteLine(this.GetType().Name +
				" eats " + h.GetType().Name);
		}
	}
}