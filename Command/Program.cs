using GangOfFour.Command.RealWorld;
using GangOfFour.Command.Structural;
using System;

namespace GangOfFour.Command
{
	internal static class Program
	{
		/// <summary>
		/// Encapsulate a request as an object, thereby letting you parameterize
		/// clients with different requests, queue or log requests, and support
		/// undoable operations.
		/// </summary>
		private static void Main()
		{
			Console.WriteLine("** Structural example **");
			MainApp.OtherMain();

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine("** Real World example **");
			Console.WriteLine();

			/* This real-world code demonstrates the Command pattern used in a simple calculator with
			 * unlimited number of undo's and redo's. Note that in C#  the word 'operator' is a keyword.
			 * Prefixing it with '@' allows using it as an identifier.*/

			// Create user and let her compute
			User user = new User();

			// User presses calculator buttons
			user.Compute('+', 100);
			user.Compute('-', 50);
			user.Compute('*', 10);
			user.Compute('/', 2);

			// Undo 4 commands
			user.Undo(4);

			// Redo 3 commands
			user.Redo(3);
		}
	}
}