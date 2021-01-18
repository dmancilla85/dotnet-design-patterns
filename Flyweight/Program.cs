using GangOfFour.Flyweight.RealWorld;
using GangOfFour.Flyweight.Structural;
using System;

namespace GangOfFour.Flyweight
{
	/// <summary>
	/// Use sharing to support large numbers of fine-grained objects efficiently.
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

			/* This real-world code demonstrates the Flyweight pattern in which a relatively small number 
			 * of Character objects is shared many times by a document that has potentially many characters.*/

			// Build a document with text
			const string document = "AAZZBBZB";
			char[] chars = document.ToCharArray();

			CharacterFactory factory = new CharacterFactory();

			// extrinsic state
			int pointSize = 10;

			// For each character use a flyweight object
			foreach (char c in chars)
			{
				pointSize++;
				Character character = factory.GetCharacter(c);
				character.Display(pointSize);
			}

		}
	}
}
