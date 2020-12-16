using GangOfFour.Command.RealWorld;
using GangOfFour.Command.Structural;
using System;

namespace GangOfFour.Command
{
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