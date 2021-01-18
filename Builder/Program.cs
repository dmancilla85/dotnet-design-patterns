using GangOfFour.Builder.RealWorld;
using GangOfFour.Builder.Structural;
using System;

namespace GangOfFour.Builder
{
	/// <summary>
	/// Separate the construction of a complex object from its representation so that the same 
	/// construction process can create different representations.
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

			/* This real-world code demonstates the Builder pattern in which different vehicles are assembled 
			 * in a step-by-step fashion. The Shop uses VehicleBuilders to construct a variety of Vehicles in 
			 * a series of sequential steps. */

			VehicleBuilder builder;

			// Create shop with vehicle builders

			Shop shop = new Shop();

			// Construct and display vehicles

			builder = new ScooterBuilder();
			shop.Construct(builder);
			builder.Vehicle.Show();

			builder = new CarBuilder();
			shop.Construct(builder);
			builder.Vehicle.Show();

			builder = new MotorCycleBuilder();
			shop.Construct(builder);
			builder.Vehicle.Show();
		}
	}
}