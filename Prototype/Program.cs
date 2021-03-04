using GangOfFour.Prototype.RealWorld;
using GangOfFour.Prototype.Structural;
using System;

namespace GangOfFour.Prototype
{
	/// <summary>
	/// Specify the kind of objects to create using a prototypical instance, and
	/// create new objects by copying this prototype.
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

			/* This real-world code demonstrates the Prototype pattern in which new Color objects are created
			 * by copying pre-existing, user-defined Colors of the same type. */

			ColorManager colormanager = new ColorManager();

			// Initialize with standard colors

			colormanager["red"] = new Color(255, 0, 0);
			colormanager["green"] = new Color(0, 255, 0);
			colormanager["blue"] = new Color(0, 0, 255);

			// User adds personalized colors

			colormanager["angry"] = new Color(255, 54, 0);
			colormanager["peace"] = new Color(128, 211, 128);
			colormanager["flame"] = new Color(211, 34, 20);

			// User clones selected colors
			Color color1 = colormanager["red"].Clone() as Color;
			Color color2 = colormanager["peace"].Clone() as Color;
			Color color3 = colormanager["flame"].Clone() as Color;

			Console.WriteLine(color1.GetType());
			Console.WriteLine(color2.GetType());
			Console.WriteLine(color3.GetType());
		}
	}
}