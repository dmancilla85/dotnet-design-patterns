using GangOfFour.AbstractFactory.RealWorld;
using GangOfFour.AbstractFactory.Structural;
using System;

namespace GangOfFour.AbstractFactory
{
	/// <summary>
	/// Provide an interface for creating families of related or dependent objects
	/// without specifying their concrete classes.
	/// </summary>
	internal static class Program
	{
		private static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			/* This real-world code demonstrates the creation of different animal worlds for a computer game
			 * using different factories. Although the animals created by the Continent factories are
			 * different, the interactions among the animals remain the same. */

			// Create and run the African animal world
			ContinentFactory africa = new AfricaFactory();
			AnimalWorld world = new AnimalWorld(africa);
			world.RunFoodChain();

			// Create and run the American animal world
			ContinentFactory america = new AmericaFactory();
			world = new AnimalWorld(america);
			world.RunFoodChain();
		}
	}
}