using GangOfFour.Adapter.RealWorld;
using GangOfFour.Adapter.Structural;
using System;

namespace GangOfFour.Adapter
{
	/// <summary>
	/// Convert the interface of a class into another interface clients expect.
	/// Adapter lets classes work together that couldn't otherwise because of
	/// incompatible interfaces.
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

			/* This real-world code demonstrates the use of a legacy chemical databank. Chemical compound
			 * objects access the databank through an Adapter interface.*/

			// Non-adapted chemical compound
			Compound unknown = new Compound("Unknown");
			unknown.Display();

			// Adapted chemical compounds
			Compound water = new RichCompound("Water");
			water.Display();

			Compound benzene = new RichCompound("Benzene");
			benzene.Display();

			Compound ethanol = new RichCompound("Ethanol");
			ethanol.Display();
		}
	}
}